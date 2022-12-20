using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TranslationsBuilder.Models;
using TranslationsBuilder.Services;

using Microsoft.AnalysisServices.Tabular;
using System.Security.AccessControl;
using TranslationsBuilder.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using static System.Windows.Forms.DataGridView;
using System.Configuration;
using System.Diagnostics;
using System.Security.Policy;

namespace TranslationsBuilder {

  public partial class FormMain : Form {

    public FormMain() {
      InitializeComponent();
      this.Text = GlobalConstants.ApplicationTitle;
    }

    private void onLoad(object sender, EventArgs e) {
      if (TranslationsManager.IsConnected) {
        LoadModel();
      }
      else {
        labelStatusBar.Text = "Not connected";
      }
    }

    public void LoadModel() {

      labelStatusBar.Text = "Loading Data Model...";

      var model = TranslationsManager.model;
      var connection = TranslationsManager.ActiveConnection;

      txtServerConnection.Text = connection.ConnectString;
      tooltipServiceConnection.SetToolTip(txtServerConnection, connection.ConnectString);
      txtDatasetName.Text = connection.DatasetName + (connection.ConnectionType == ConnectionType.PowerBiDesktop ? ".pbix" : "");
      tooltipDatasetName.SetToolTip(txtDatasetName, connection.DatasetName);

      txtDefaultCulture.Text = SupportedLanguages.AllLangauges[model.Culture].FullName;
      txtCompatibilityLevel.Text = model.Database.CompatibilityLevel.ToString();
      txtEstimatedSize.Text = (model.Database.EstimatedSize / 1000000).ToString("0.00") + " MB";

      listSecondaryCultures.Items.Clear();
      listSecondaryCultures.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());

      listLanguageForTransation.Items.Clear();
      listLanguageForTransation.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());
      if (listLanguageForTransation.Items.Count > 0) {
        listLanguageForTransation.SelectedIndex = 0;
      }

      listCultureToPopulate.Items.Clear();
      listCultureToPopulate.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());
      if (listCultureToPopulate.Items.Count > 0) {
        listCultureToPopulate.SelectedIndex = 0;
      }

      gridTranslations.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
      gridTranslations.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
      gridTranslations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      gridTranslations.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
      gridTranslations.AllowUserToAddRows = false;

      SetGenenrateMachineTranslationsButton();

      SetMenuCommands();

      PopulateGridWithTranslations();

      labelStatusBar.Text = "Data Model loaded successfully";

    }

    private void menuConnect_Click(object sender, EventArgs e) {

      bool sessionsExist = (PowerBiDesktopUtilities.GetActiveDatasetConnections().Count() > 0);

      if (sessionsExist) {
        using (FormConnect dialog = new FormConnect()) {
          dialog.StartPosition = FormStartPosition.CenterScreen;
          dialog.ShowDialog(this);
          if (dialog.DialogResult == DialogResult.OK && !string.IsNullOrEmpty(dialog.ConnectString)) {
            if (TranslationsManager.IsConnected) {
              TranslationsManager.Disconnect();
              InitializeAfterDisconected();
            }
            TranslationsManager.Connect(dialog.ConnectString);
            LoadModel();
          }
        }
      }
      else {
        UserInteraction.PromptUserWithInformation("You cannot create a local dataset connection because there are no active sessions of Power BI Desktop.\r\n\r\nStart a session of Power BI Desktop so you can to connect.");
      }

    }

    private void menuDisconnect_Click(object sender, EventArgs e) {
      TranslationsManager.Disconnect();
      InitializeAfterDisconected();
    }

    public void InitializeAfterDisconected() {

      txtServerConnection.Text = "";
      txtDatasetName.Text = "";

      txtDefaultCulture.Text = "";
      txtCompatibilityLevel.Text = "";
      txtEstimatedSize.Text = "";

      listSecondaryCultures.Items.Clear();

      listLanguageForTransation.Items.Clear();

      listCultureToPopulate.Items.Clear();

      gridTranslations.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
      gridTranslations.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
      gridTranslations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      gridTranslations.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
      gridTranslations.AllowUserToAddRows = false;

      SetMenuCommands();

      gridTranslations.Rows.Clear();
      gridTranslations.Columns.Clear();

      labelStatusBar.Text = "Not connected";

    }

    public void PopulateGridWithTranslations() {

      gridTranslations.Rows.Clear();
      gridTranslations.Columns.Clear();

      TranslationsManager.RefreshDataFromServer();
      var translationsTable = TranslationsManager.GetTranslationsTable();

      // populate colum headers
      gridTranslations.ColumnCount = translationsTable.Headers.Length;
      for (int index = 0; index <= translationsTable.Headers.Length - 1; index++) {
        string language = translationsTable.Headers[index];
        gridTranslations.Columns[index].Name = language;

        // add context menu to delete secondary language
        if (index > 3) {
          gridTranslations.Columns[index].HeaderCell.ContextMenuStrip = contextMenuSecondaryLanguageHeader;
        }
        // only enable translated column cells for update
        gridTranslations.Columns[index].ReadOnly = index <= 3;
      }

      // populate rows
      foreach (var row in translationsTable.Rows) {
        gridTranslations.Rows.Add(row);
      }

      gridTranslations.AutoResizeColumns();
      gridTranslations.ClearSelection();
      this.Refresh();
    }

    private void AddSecondaryCulture(object sender, EventArgs e) {

      using (FormAddCultureDialog dialog = new FormAddCultureDialog()) {

        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.ShowDialog(this);

        if (dialog.DialogResult == DialogResult.OK) {

          string[] languages = dialog.getLanguages();
          string lastLanguage = "";
          foreach (string language in languages) {
            TranslationsManager.model.Cultures.Add(new Culture { Name = language });
            lastLanguage = language;
          }
          TranslationsManager.model.SaveChanges();
          listSecondaryCultures.Items.Clear();
          listSecondaryCultures.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());
          PopulateGridWithTranslations();

          string lastLanguageFullName = SupportedLanguages.AllLangauges[lastLanguage].FullName;

          listCultureToPopulate.Items.Clear();
          listCultureToPopulate.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());
          listCultureToPopulate.SelectedIndex = listCultureToPopulate.Items.IndexOf(lastLanguageFullName);

          listLanguageForTransation.Items.Clear();
          listLanguageForTransation.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());
          listLanguageForTransation.SelectedIndex = listLanguageForTransation.Items.IndexOf(lastLanguageFullName);
          labelStatusBar.Text = "New Culture[" + lastLanguageFullName + "] successfully added";
        }
      }
    }

    private void ExportTranslationsSheet(object sender, EventArgs e) {
      labelStatusBar.Text = "Exporting Translations";
      Language targetLanguage = SupportedLanguages.GetLanguageFromFullName(listLanguageForTransation.SelectedItem.ToString());
      TranslationsManager.ExportTranslations(targetLanguage.LanguageTag, chkOpenExportInExcel.Checked);
      labelStatusBar.Text = "Translations export Complete";
    }

    private void ExportAllTranslations(object sender, EventArgs e) {
      labelStatusBar.Text = "Exporting Translations";
      TranslationsManager.ExportTranslations(null, chkOpenExportInExcel.Checked);
      labelStatusBar.Text = "Translations export Complete";
    }

    private void ExportAllTranslationSheets(object sender, EventArgs e) {
      labelStatusBar.Text = "Exporting Translations";
      TranslationsManager.ExportAllTranslationSheets(chkOpenExportInExcel.Checked);
      labelStatusBar.Text = "Translations export Complete";
    }

    private void ImportTranslations(object sender, EventArgs e) {

      dialogOpenFile.InitialDirectory = AppSettings.TranslationsInboxFolderPath;
      dialogOpenFile.Filter = "CSV files (*.csv)|*.csv";
      dialogOpenFile.FilterIndex = 1;
      dialogOpenFile.RestoreDirectory = true;

      if (dialogOpenFile.ShowDialog() == DialogResult.OK) {
        TranslationsManager.ImportTranslations(dialogOpenFile.FileName);
        LoadModel();
        PopulateGridWithTranslations();
      }

    }


    private void ConfigureSettings(object sender, EventArgs e) {
      using (FormConfig dialog = new FormConfig()) {
        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.ShowDialog(this);
        if (dialog.DialogResult == DialogResult.OK) {
          SetGenenrateMachineTranslationsButton();
        }
      }
    }

    private void SetGenenrateMachineTranslationsButton() {
      if (TranslatorService.IsAvailable) {
        grpMachineTranslationsSingleLanguage.Visible = true;
        grpMachineTranslationsAllLanguages.Visible = true;
      }
      else {
        grpMachineTranslationsSingleLanguage.Visible = false;
        grpMachineTranslationsAllLanguages.Visible = false;
      }
    }

    private void SetMenuCommands() {

      menuDisconnect.Enabled = TranslationsManager.IsConnected;

      bool localizedLabelsTableExists = TranslationsManager.DoesTableExistInModel(TranslationsManager.LocalizedLabelsTableName);
      menuCreateLocalizedLabelsTable.Enabled = !localizedLabelsTableExists;
      menuAddLabelsToLocalizedLabelsTable.Enabled = localizedLabelsTableExists;
      menuGenerateTranslatedLocalizedLabelsTable.Enabled = localizedLabelsTableExists;
      bool translatedReportLabelsTableExists = TranslationsManager.DoesTableExistInModel(TranslationsManager.TranslatedReportLabelMatrixName);
      menuGenerateTranslatedReportLabelMatrixMeasures.Enabled = translatedReportLabelsTableExists;
      bool translatedReportLabelsByLanguageTableExists = TranslationsManager.DoesTableExistInModel(TranslationsManager.TranslatedReportLabelTableName);
      menuGenerateTranslatedReportLabelTableMeasures.Enabled = translatedReportLabelsByLanguageTableExists;
      menuGenerateTranslatedDatasetObjectNamesTable.Enabled = TranslationsManager.TranslationsExist();
    }

    private void SetDatasetName(object sender, EventArgs e) {
      using (FormSetDatasetName dialog = new FormSetDatasetName()) {
        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.DatasetName = TranslationsManager.DatasetName;
        dialog.ShowDialog(this);
        if (dialog.DialogResult == DialogResult.OK) {
          TranslationsManager.DatasetAnnotationForName = dialog.DatasetName;
          txtDatasetName.Text = dialog.DatasetName;
        }
      }
    }

    private void GenenrateMachineTranslations(object sender, EventArgs e) {

      Language targetLanguage = SupportedLanguages.GetLanguageFromFullName(listCultureToPopulate.SelectedItem.ToString());
      string targetLanguageTag = targetLanguage.LanguageTag;

      using (FormLoadingStatus dialog = new FormLoadingStatus()) {
        dialog.StartPosition = FormStartPosition.CenterScreen;
        dialog.Show(this);
        TranslationsManager.PopulateCultureWithMachineTranslations(targetLanguageTag, dialog);
        dialog.Close();
      }

      PopulateGridWithTranslations();
    }

    private void FillEmptyTranslations(object sender, EventArgs e) {

      Language targetLanguage = SupportedLanguages.GetLanguageFromFullName(listCultureToPopulate.SelectedItem.ToString());
      string targetLanguageTag = targetLanguage.LanguageTag;

      using (FormLoadingStatus dialog = new FormLoadingStatus()) {
        dialog.StartPosition = FormStartPosition.CenterScreen;
        dialog.Show(this);
        TranslationsManager.PopulateEmptyTranslations(targetLanguageTag, dialog);
        dialog.Close();
      }

      PopulateGridWithTranslations();
    }

    private void GenenrateAllMachineTranslations(object sender, EventArgs e) {

      using (FormLoadingStatus dialog = new FormLoadingStatus()) {

        dialog.StartPosition = FormStartPosition.CenterScreen;
        dialog.Show(this);

        foreach (var language in TranslationsManager.GetSecondaryCulturesInDataModel()) {
          TranslationsManager.PopulateCultureWithMachineTranslations(language, dialog);
          PopulateGridWithTranslations();
        }

        dialog.Close();
      }

      PopulateGridWithTranslations();

    }

    private void FillAllEmptyTranslations(object sender, EventArgs e) {

      labelStatusBar.Text = "Executing FillAllEmptyTranslations operation...";

      using (FormLoadingStatus dialog = new FormLoadingStatus()) {

        dialog.StartPosition = FormStartPosition.CenterScreen;
        dialog.Show(this);

        foreach (var language in TranslationsManager.GetSecondaryCulturesInDataModel()) {
          TranslationsManager.PopulateEmptyTranslations(language, dialog);
          PopulateGridWithTranslations();
        }

        dialog.Close();
      }
      PopulateGridWithTranslations();
      labelStatusBar.Text = "FillAllEmptyTranslations operation completed successfully";
    }

    private void RefreshTranslationsTable(object sender, EventArgs e) {
      PopulateGridWithTranslations();
    }

    private void CreateLocalizedLabelsTable(object sender, EventArgs e) {
      labelStatusBar.Text = "Creating Localized Labels table...";
      TranslationsManager.CreateLocalizedLabelsTable();
      SetMenuCommands();
      PopulateGridWithTranslations();
      labelStatusBar.Text = "Localized Labels table generated at " + DateTime.Now.ToShortTimeString();
      UserInteraction.PromptOnLocalizedLabelsTableCreate();
    }

    private void GenerateTranslatedLocalizedLabelsTable(object sender, EventArgs e) {
      labelStatusBar.Text = "Creating Translated Localized Labels table...";
      TranslationsManager.GenerateTranslatedLocalizedLabelsTable();
      labelStatusBar.Text = "[Translated Localized Labels] table generated at " + DateTime.Now.ToShortTimeString();

    }

    private void GenerateTranslatedDatasetObjectNamesTable(object sender, EventArgs e) {
      labelStatusBar.Text = "Creating Translated Database Object Names table...";
      TranslationsManager.GenerateTranslatedDatasetObjectsTable();
      labelStatusBar.Text = "[Translated Database Object Names] table generated at " + DateTime.Now.ToShortTimeString();
    }

    private void GenerateTranslatedReportLabelMatrixMeasures(object sender, EventArgs e) {
      labelStatusBar.Text = "Creating Translated Report Label Matrix measures...";
      TranslationsManager.GenerateTranslatedReportLabelMatrixMeasures();
      labelStatusBar.Text = "[Translated Report Label Matrix] measures generated at " + DateTime.Now.ToShortTimeString();
    }

    private void GenerateTranslatedReportLabelTableMeasures(object sender, EventArgs e) {
      labelStatusBar.Text = "Creating Translated Report Label Table measures...";
      TranslationsManager.GenerateTranslatedReportLabelTableMeasures();
      labelStatusBar.Text = "[Translated Report Label Table] measures generated at " + DateTime.Now.ToShortTimeString();
    }

    private void SyncDataModel(object sender, EventArgs e) {
      PopulateGridWithTranslations();
      SetMenuCommands();
    }

    private void AddLocalizedLabels(object sender, EventArgs e) {

      using (FormAddLocalizedLabels dialog = new FormAddLocalizedLabels()) {

        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.frmMain = this;
        dialog.ShowDialog(this);
        if (dialog.DialogResult == DialogResult.OK) {
          labelStatusBar.Text = "Localized Label added at " + DateTime.Now.ToShortTimeString();
          PopulateGridWithTranslations();
        }
      }
    }

    private void gridTranslations_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

      if (e.ColumnIndex == -1 && TranslatorService.IsAvailable) {
        // allow double click on row heading to generate machine translation for all secondary languages across row

        string objectType = gridTranslations.Rows[e.RowIndex].Cells[0]?.Value.ToString();
        string propertyName = gridTranslations.Rows[e.RowIndex].Cells[1]?.Value.ToString();
        string objectName = gridTranslations.Rows[e.RowIndex].Cells[2]?.Value.ToString();

        using (FormLoadingStatus dialog = new FormLoadingStatus()) {
          dialog.StartPosition = FormStartPosition.CenterScreen;
          dialog.Show(this);
          TranslationsManager.PopulateDatasetObjectWithMachineTranslations(objectType, propertyName, objectName, dialog);
          dialog.Close();
        }
        PopulateGridWithTranslations();

      }

      if (e.ColumnIndex == 2) {
        var cell = gridTranslations.Rows[e.RowIndex].Cells[e.ColumnIndex];
        string cellContents = (cell.Value != null) ? cell.Value.ToString() : "";

        if (cellContents.Contains("Localized Labels")) {
          string labelName = cellContents.Replace("Localized Labels[", "").Replace("]", "");
          using (FormEditLocalizedLabel dialog = new FormEditLocalizedLabel(labelName)) {
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK) {
              labelStatusBar.Text = "Measure (" + labelName + ") generated at " + DateTime.Now.ToShortTimeString();
              PopulateGridWithTranslations();
            }
          }
        }
      }

      if (e.ColumnIndex == 3 && e.RowIndex >= 0) {
        var cell = gridTranslations.Rows[e.RowIndex].Cells[e.ColumnIndex];
        string cellContents = (cell.Value != null) ? cell.Value.ToString() : "";

        // this is the default translation when column index is 3
        var ObjectType = gridTranslations.Rows[e.RowIndex].Cells[0].Value.ToString();
        var PropertyName = gridTranslations.Rows[e.RowIndex].Cells[1].Value.ToString();
        var ObjectName = gridTranslations.Rows[e.RowIndex].Cells[2].Value.ToString();
        var Language = SupportedLanguages.GetLanguageFromFullName(gridTranslations.Columns[e.ColumnIndex].HeaderText).LanguageTag;


        using (FormEditDefaultTranslation dialog = new FormEditDefaultTranslation(ObjectType, PropertyName, ObjectName, Language, cellContents)) {
          dialog.StartPosition = FormStartPosition.CenterParent;
          dialog.ShowDialog(this);
          if (dialog.DialogResult == DialogResult.OK) {
            labelStatusBar.Text = ObjectName + " updated at " + DateTime.Now.ToShortTimeString();
            PopulateGridWithTranslations();
          }
        }

      }

      if (e.ColumnIndex >= 4 && e.RowIndex >= 0) {
        var cell = gridTranslations.Rows[e.RowIndex].Cells[e.ColumnIndex];
        string cellContents = (cell.Value != null) ? cell.Value.ToString() : "";

        // this is a secondary translation when column index is 4 or greater
        var ObjectType = gridTranslations.Rows[e.RowIndex].Cells[0].Value.ToString();
        var PropertyName = gridTranslations.Rows[e.RowIndex].Cells[1].Value.ToString();
        var ObjectName = gridTranslations.Rows[e.RowIndex].Cells[2].Value.ToString();
        var Language = SupportedLanguages.GetLanguageFromFullName(gridTranslations.Columns[e.ColumnIndex].HeaderText).LanguageTag;


        using (FormEditTranslation dialog = new FormEditTranslation(ObjectType, PropertyName, ObjectName, Language, cellContents)) {
          dialog.StartPosition = FormStartPosition.CenterParent;
          dialog.ShowDialog(this);
          if (dialog.DialogResult == DialogResult.OK) {
            labelStatusBar.Text = ObjectName + " updated at " + DateTime.Now.ToShortTimeString();
            PopulateGridWithTranslations();
          }
        }

      }

    }

    private void gridTranslations_CellEndEdit(object sender, DataGridViewCellEventArgs e) {

      // get updated cell
      var cell = gridTranslations.Rows[e.RowIndex].Cells[e.ColumnIndex];

      // update translation value in model
      var ObjectType = gridTranslations.Rows[e.RowIndex].Cells[0].Value.ToString();
      var PropertyName = gridTranslations.Rows[e.RowIndex].Cells[1].Value.ToString();
      var ObjectName = gridTranslations.Rows[e.RowIndex].Cells[2].Value.ToString();
      var Language = SupportedLanguages.GetLanguageFromFullName(gridTranslations.Columns[e.ColumnIndex].HeaderText).LanguageTag;
      string Translation = (cell.Value != null) ? cell.Value.ToString() : "";
      TranslationsManager.SetDatasetObjectTranslation(ObjectType, PropertyName, ObjectName, Language, Translation);
      cell.Style.BackColor = System.Drawing.Color.White;
    }

    private void gridTranslations_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {

      var cell = gridTranslations.Rows[e.RowIndex].Cells[e.ColumnIndex];
      cell.Style.BackColor = System.Drawing.Color.Yellow;

    }

    private void menuCommandDeleteSecondaryLanguage_MouseDown(object sender, MouseEventArgs e) {



    }

    private void gridTranslations_MouseDown(object sender, MouseEventArgs e) {



    }

    private void contextMenuSecondaryLanguageHeader_MouseClick(object sender, MouseEventArgs e) {

      ContextMenuStrip contextMenu = sender as ContextMenuStrip;
      Point pScreen = contextMenu.PointToScreen(new Point(e.X, e.Y));
      Point pGrid = gridTranslations.PointToClient(pScreen);
      var columnIndex = gridTranslations.HitTest(pGrid.X, pGrid.Y).ColumnIndex;

      if (columnIndex == -1) {
        columnIndex = 4;
      }

      var language = gridTranslations.Columns[columnIndex].HeaderText;

      string confirmDeleteMessage = "Are you sure you want to delete the language - " + language + "?\r\n" +
                                    "Deleting this secondary language will delete all its translations.";

      contextMenu.Hide();

      bool userConfirmedOperation = UserInteraction.PromptUserToConfirmOperation(confirmDeleteMessage, "Delete Secondary Language Operation");
      if (userConfirmedOperation) {

        string languageTag = SupportedLanguages.GetLanguageFromFullName(language).LanguageTag;
        TranslationsManager.DeleteSecondaryCulture(languageTag);

        listSecondaryCultures.Items.Clear();
        listSecondaryCultures.Items.AddRange(TranslationsManager.GetSecondaryCultureFullNamesInDataModel().ToArray());

        listLanguageForTransation.Items.Remove(language);
        if (listLanguageForTransation.SelectedIndex == -1 && listLanguageForTransation.Items.Count > 0) {
          listLanguageForTransation.SelectedIndex = 0;
        }

        listCultureToPopulate.Items.Remove(language);
        if (listCultureToPopulate.SelectedIndex == -1 && listCultureToPopulate.Items.Count > 0) {
          listCultureToPopulate.SelectedIndex = 0;
        }

        PopulateGridWithTranslations();
      }
    }

    private void exportModelAsJson_Click(object sender, EventArgs e) {
      TranslationsManager.ExportModelAsBim();
    }

  
  }
}
