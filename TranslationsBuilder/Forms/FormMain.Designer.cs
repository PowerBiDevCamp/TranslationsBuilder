
using System.Drawing;
using System.Windows.Forms;

namespace TranslationsBuilder {
  partial class FormMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.gridTranslations = new System.Windows.Forms.DataGridView();
      this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
      this.groupDefaultCulture = new System.Windows.Forms.GroupBox();
      this.lblDefaultCultureNameLabel = new System.Windows.Forms.Label();
      this.btnPopulateDefaultCultureTranslations = new System.Windows.Forms.Button();
      this.txtDefaultCulture = new System.Windows.Forms.TextBox();
      this.groupDatasetProperties = new System.Windows.Forms.GroupBox();
      this.txtEstimatedSize = new System.Windows.Forms.TextBox();
      this.lblEstimatedSize = new System.Windows.Forms.Label();
      this.txtCompatibilityLevel = new System.Windows.Forms.TextBox();
      this.lblCompatibilityLevel = new System.Windows.Forms.Label();
      this.txtDatasetName = new System.Windows.Forms.TextBox();
      this.txtServerConnection = new System.Windows.Forms.TextBox();
      this.lblDatasetName = new System.Windows.Forms.Label();
      this.lblServerConnection = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.grpImportExportTranslations = new System.Windows.Forms.GroupBox();
      this.listLanguageForTransation = new System.Windows.Forms.ComboBox();
      this.btnExportTranslations = new System.Windows.Forms.Button();
      this.btnImportTranslations = new System.Windows.Forms.Button();
      this.btnExportTranslationsSheet = new System.Windows.Forms.Button();
      this.grpMachineTranslations = new System.Windows.Forms.GroupBox();
      this.btnFillEmptyTranslations = new System.Windows.Forms.Button();
      this.btnFillAllEmptyTranslations = new System.Windows.Forms.Button();
      this.btnGenenrateAllMachineTranslations = new System.Windows.Forms.Button();
      this.btnGenenrateMachineTranslations = new System.Windows.Forms.Button();
      this.listCultureToPopulate = new System.Windows.Forms.ComboBox();
      this.grpSecondaryCultures = new System.Windows.Forms.GroupBox();
      this.addSecondaryCulture = new System.Windows.Forms.Button();
      this.listSecondaryCultures = new System.Windows.Forms.ListBox();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.menuConnection = new System.Windows.Forms.ToolStripMenuItem();
      this.menuConnect = new System.Windows.Forms.ToolStripMenuItem();
      this.menuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.menuConfigureSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exportModelAsJson = new System.Windows.Forms.ToolStripMenuItem();
      this.menuTranslatedTables = new System.Windows.Forms.ToolStripMenuItem();
      this.menuCreateLocalizedLabelsTable = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAddLabelsToLocalizedLabelsTable = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGenerateTranslatedLocalizedLabelsTable = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGenerateTranslatedDatasetObjectNamesTable = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGenerateTranslatedReportLabelMatrixMeasures = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGenerateTranslatedReportLabelTableMeasures = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSyncDataModel = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.labelStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tooltipDatasetName = new System.Windows.Forms.ToolTip(this.components);
      this.tooltipServiceConnection = new System.Windows.Forms.ToolTip(this.components);
      this.contextMenuSecondaryLanguageHeader = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.menuCommandDeleteSecondaryLanguage = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.gridTranslations)).BeginInit();
      this.groupDefaultCulture.SuspendLayout();
      this.groupDatasetProperties.SuspendLayout();
      this.panel2.SuspendLayout();
      this.grpImportExportTranslations.SuspendLayout();
      this.grpMachineTranslations.SuspendLayout();
      this.grpSecondaryCultures.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.contextMenuSecondaryLanguageHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // gridTranslations
      // 
      this.gridTranslations.AllowUserToAddRows = false;
      this.gridTranslations.AllowUserToDeleteRows = false;
      this.gridTranslations.AllowUserToResizeColumns = false;
      this.gridTranslations.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gridTranslations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.gridTranslations.ColumnHeadersHeight = 29;
      this.gridTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.gridTranslations.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTranslations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.gridTranslations.EnableHeadersVisualStyles = false;
      this.gridTranslations.Location = new System.Drawing.Point(0, 305);
      this.gridTranslations.MultiSelect = false;
      this.gridTranslations.Name = "gridTranslations";
      this.gridTranslations.RowHeadersWidth = 24;
      this.gridTranslations.RowTemplate.Height = 28;
      this.gridTranslations.Size = new System.Drawing.Size(1416, 434);
      this.gridTranslations.TabIndex = 0;
      this.gridTranslations.TabStop = false;
      this.gridTranslations.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridTranslations_CellBeginEdit);
      this.gridTranslations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTranslations_CellDoubleClick);
      this.gridTranslations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTranslations_CellEndEdit);
      // 
      // dialogOpenFile
      // 
      this.dialogOpenFile.FileName = "openFileDialog1";
      // 
      // groupDefaultCulture
      // 
      this.groupDefaultCulture.Controls.Add(this.lblDefaultCultureNameLabel);
      this.groupDefaultCulture.Controls.Add(this.btnPopulateDefaultCultureTranslations);
      this.groupDefaultCulture.Controls.Add(this.txtDefaultCulture);
      this.groupDefaultCulture.Location = new System.Drawing.Point(464, 45);
      this.groupDefaultCulture.Name = "groupDefaultCulture";
      this.groupDefaultCulture.Size = new System.Drawing.Size(224, 244);
      this.groupDefaultCulture.TabIndex = 1;
      this.groupDefaultCulture.TabStop = false;
      this.groupDefaultCulture.Text = "Default Culture";
      // 
      // lblDefaultCultureNameLabel
      // 
      this.lblDefaultCultureNameLabel.AutoSize = true;
      this.lblDefaultCultureNameLabel.Location = new System.Drawing.Point(14, 35);
      this.lblDefaultCultureNameLabel.Name = "lblDefaultCultureNameLabel";
      this.lblDefaultCultureNameLabel.Size = new System.Drawing.Size(52, 20);
      this.lblDefaultCultureNameLabel.TabIndex = 31;
      this.lblDefaultCultureNameLabel.Text = "Name:";
      // 
      // btnPopulateDefaultCultureTranslations
      // 
      this.btnPopulateDefaultCultureTranslations.Location = new System.Drawing.Point(11, 69);
      this.btnPopulateDefaultCultureTranslations.Name = "btnPopulateDefaultCultureTranslations";
      this.btnPopulateDefaultCultureTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnPopulateDefaultCultureTranslations.TabIndex = 1;
      this.btnPopulateDefaultCultureTranslations.Text = "Populate Translations";
      this.btnPopulateDefaultCultureTranslations.UseVisualStyleBackColor = true;
      this.btnPopulateDefaultCultureTranslations.Click += new System.EventHandler(this.PopulateDefaultCultureTranslations);
      // 
      // txtDefaultCulture
      // 
      this.txtDefaultCulture.Location = new System.Drawing.Point(69, 29);
      this.txtDefaultCulture.Name = "txtDefaultCulture";
      this.txtDefaultCulture.Size = new System.Drawing.Size(143, 27);
      this.txtDefaultCulture.TabIndex = 0;
      this.txtDefaultCulture.TabStop = false;
      // 
      // groupDatasetProperties
      // 
      this.groupDatasetProperties.Controls.Add(this.txtEstimatedSize);
      this.groupDatasetProperties.Controls.Add(this.lblEstimatedSize);
      this.groupDatasetProperties.Controls.Add(this.txtCompatibilityLevel);
      this.groupDatasetProperties.Controls.Add(this.lblCompatibilityLevel);
      this.groupDatasetProperties.Controls.Add(this.txtDatasetName);
      this.groupDatasetProperties.Controls.Add(this.txtServerConnection);
      this.groupDatasetProperties.Controls.Add(this.lblDatasetName);
      this.groupDatasetProperties.Controls.Add(this.lblServerConnection);
      this.groupDatasetProperties.Location = new System.Drawing.Point(9, 45);
      this.groupDatasetProperties.Name = "groupDatasetProperties";
      this.groupDatasetProperties.Size = new System.Drawing.Size(440, 244);
      this.groupDatasetProperties.TabIndex = 0;
      this.groupDatasetProperties.TabStop = false;
      this.groupDatasetProperties.Text = "Dataset Properties";
      // 
      // txtEstimatedSize
      // 
      this.txtEstimatedSize.Location = new System.Drawing.Point(121, 141);
      this.txtEstimatedSize.Name = "txtEstimatedSize";
      this.txtEstimatedSize.ReadOnly = true;
      this.txtEstimatedSize.Size = new System.Drawing.Size(307, 27);
      this.txtEstimatedSize.TabIndex = 26;
      this.txtEstimatedSize.TabStop = false;
      // 
      // lblEstimatedSize
      // 
      this.lblEstimatedSize.AutoSize = true;
      this.lblEstimatedSize.Location = new System.Drawing.Point(11, 147);
      this.lblEstimatedSize.Name = "lblEstimatedSize";
      this.lblEstimatedSize.Size = new System.Drawing.Size(109, 20);
      this.lblEstimatedSize.TabIndex = 25;
      this.lblEstimatedSize.Text = "Estimated Size:";
      this.lblEstimatedSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtCompatibilityLevel
      // 
      this.txtCompatibilityLevel.Location = new System.Drawing.Point(121, 104);
      this.txtCompatibilityLevel.Name = "txtCompatibilityLevel";
      this.txtCompatibilityLevel.ReadOnly = true;
      this.txtCompatibilityLevel.Size = new System.Drawing.Size(307, 27);
      this.txtCompatibilityLevel.TabIndex = 22;
      this.txtCompatibilityLevel.TabStop = false;
      // 
      // lblCompatibilityLevel
      // 
      this.lblCompatibilityLevel.AutoSize = true;
      this.lblCompatibilityLevel.Location = new System.Drawing.Point(17, 109);
      this.lblCompatibilityLevel.Name = "lblCompatibilityLevel";
      this.lblCompatibilityLevel.Size = new System.Drawing.Size(103, 20);
      this.lblCompatibilityLevel.TabIndex = 21;
      this.lblCompatibilityLevel.Text = "Compat Level:";
      this.lblCompatibilityLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtDatasetName
      // 
      this.txtDatasetName.Location = new System.Drawing.Point(121, 67);
      this.txtDatasetName.Name = "txtDatasetName";
      this.txtDatasetName.ReadOnly = true;
      this.txtDatasetName.Size = new System.Drawing.Size(307, 27);
      this.txtDatasetName.TabIndex = 20;
      this.txtDatasetName.TabStop = false;
      // 
      // txtServerConnection
      // 
      this.txtServerConnection.Location = new System.Drawing.Point(121, 29);
      this.txtServerConnection.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.txtServerConnection.Name = "txtServerConnection";
      this.txtServerConnection.ReadOnly = true;
      this.txtServerConnection.Size = new System.Drawing.Size(307, 27);
      this.txtServerConnection.TabIndex = 0;
      this.txtServerConnection.TabStop = false;
      // 
      // lblDatasetName
      // 
      this.lblDatasetName.AutoSize = true;
      this.lblDatasetName.Location = new System.Drawing.Point(10, 73);
      this.lblDatasetName.Name = "lblDatasetName";
      this.lblDatasetName.Size = new System.Drawing.Size(107, 20);
      this.lblDatasetName.TabIndex = 18;
      this.lblDatasetName.Text = "Dataset Name:";
      this.lblDatasetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblServerConnection
      // 
      this.lblServerConnection.AutoSize = true;
      this.lblServerConnection.Location = new System.Drawing.Point(27, 37);
      this.lblServerConnection.Name = "lblServerConnection";
      this.lblServerConnection.Size = new System.Drawing.Size(87, 20);
      this.lblServerConnection.TabIndex = 17;
      this.lblServerConnection.Text = "Connection:";
      this.lblServerConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel2.Controls.Add(this.grpImportExportTranslations);
      this.panel2.Controls.Add(this.grpMachineTranslations);
      this.panel2.Controls.Add(this.grpSecondaryCultures);
      this.panel2.Controls.Add(this.groupDatasetProperties);
      this.panel2.Controls.Add(this.groupDefaultCulture);
      this.panel2.Controls.Add(this.menuStrip);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1416, 305);
      this.panel2.TabIndex = 8;
      // 
      // grpImportExportTranslations
      // 
      this.grpImportExportTranslations.Controls.Add(this.listLanguageForTransation);
      this.grpImportExportTranslations.Controls.Add(this.btnExportTranslations);
      this.grpImportExportTranslations.Controls.Add(this.btnImportTranslations);
      this.grpImportExportTranslations.Controls.Add(this.btnExportTranslationsSheet);
      this.grpImportExportTranslations.Location = new System.Drawing.Point(938, 43);
      this.grpImportExportTranslations.Name = "grpImportExportTranslations";
      this.grpImportExportTranslations.Size = new System.Drawing.Size(224, 246);
      this.grpImportExportTranslations.TabIndex = 4;
      this.grpImportExportTranslations.TabStop = false;
      this.grpImportExportTranslations.Text = "Export/Import Translations";
      // 
      // listLanguageForTransation
      // 
      this.listLanguageForTransation.BackColor = System.Drawing.SystemColors.Window;
      this.listLanguageForTransation.FormattingEnabled = true;
      this.listLanguageForTransation.Location = new System.Drawing.Point(13, 65);
      this.listLanguageForTransation.Name = "listLanguageForTransation";
      this.listLanguageForTransation.Size = new System.Drawing.Size(198, 28);
      this.listLanguageForTransation.TabIndex = 6;
      // 
      // btnExportTranslations
      // 
      this.btnExportTranslations.Location = new System.Drawing.Point(11, 99);
      this.btnExportTranslations.Name = "btnExportTranslations";
      this.btnExportTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnExportTranslations.TabIndex = 7;
      this.btnExportTranslations.Text = "Export All Translations";
      this.btnExportTranslations.UseVisualStyleBackColor = true;
      this.btnExportTranslations.Click += new System.EventHandler(this.ExportTranslations);
      // 
      // btnImportTranslations
      // 
      this.btnImportTranslations.Location = new System.Drawing.Point(11, 141);
      this.btnImportTranslations.Name = "btnImportTranslations";
      this.btnImportTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnImportTranslations.TabIndex = 8;
      this.btnImportTranslations.Text = "Import Translations";
      this.btnImportTranslations.UseVisualStyleBackColor = true;
      this.btnImportTranslations.Click += new System.EventHandler(this.ImportTranslations);
      // 
      // btnExportTranslationsSheet
      // 
      this.btnExportTranslationsSheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnExportTranslationsSheet.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnExportTranslationsSheet.Location = new System.Drawing.Point(11, 24);
      this.btnExportTranslationsSheet.Name = "btnExportTranslationsSheet";
      this.btnExportTranslationsSheet.Size = new System.Drawing.Size(200, 36);
      this.btnExportTranslationsSheet.TabIndex = 5;
      this.btnExportTranslationsSheet.Text = "Export Translations Sheet";
      this.btnExportTranslationsSheet.UseVisualStyleBackColor = false;
      this.btnExportTranslationsSheet.Click += new System.EventHandler(this.ExportTranslationsSheet);
      // 
      // grpMachineTranslations
      // 
      this.grpMachineTranslations.Controls.Add(this.btnFillEmptyTranslations);
      this.grpMachineTranslations.Controls.Add(this.btnFillAllEmptyTranslations);
      this.grpMachineTranslations.Controls.Add(this.btnGenenrateAllMachineTranslations);
      this.grpMachineTranslations.Controls.Add(this.btnGenenrateMachineTranslations);
      this.grpMachineTranslations.Controls.Add(this.listCultureToPopulate);
      this.grpMachineTranslations.Location = new System.Drawing.Point(1175, 43);
      this.grpMachineTranslations.Name = "grpMachineTranslations";
      this.grpMachineTranslations.Size = new System.Drawing.Size(224, 246);
      this.grpMachineTranslations.TabIndex = 9;
      this.grpMachineTranslations.TabStop = false;
      this.grpMachineTranslations.Text = "Machine Translations";
      // 
      // btnFillEmptyTranslations
      // 
      this.btnFillEmptyTranslations.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnFillEmptyTranslations.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnFillEmptyTranslations.Location = new System.Drawing.Point(13, 99);
      this.btnFillEmptyTranslations.Name = "btnFillEmptyTranslations";
      this.btnFillEmptyTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnFillEmptyTranslations.TabIndex = 14;
      this.btnFillEmptyTranslations.Text = "Fill Empty Translations";
      this.btnFillEmptyTranslations.UseVisualStyleBackColor = false;
      this.btnFillEmptyTranslations.Click += new System.EventHandler(this.FillEmptyTranslations);
      // 
      // btnFillAllEmptyTranslations
      // 
      this.btnFillAllEmptyTranslations.Location = new System.Drawing.Point(11, 180);
      this.btnFillAllEmptyTranslations.Name = "btnFillAllEmptyTranslations";
      this.btnFillAllEmptyTranslations.Size = new System.Drawing.Size(200, 37);
      this.btnFillAllEmptyTranslations.TabIndex = 13;
      this.btnFillAllEmptyTranslations.Text = "Fill All Empty Translations";
      this.btnFillAllEmptyTranslations.UseVisualStyleBackColor = true;
      this.btnFillAllEmptyTranslations.Click += new System.EventHandler(this.FillAllEmptyTranslations);
      // 
      // btnGenenrateAllMachineTranslations
      // 
      this.btnGenenrateAllMachineTranslations.Location = new System.Drawing.Point(11, 139);
      this.btnGenenrateAllMachineTranslations.Name = "btnGenenrateAllMachineTranslations";
      this.btnGenenrateAllMachineTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnGenenrateAllMachineTranslations.TabIndex = 12;
      this.btnGenenrateAllMachineTranslations.Text = "Generate All Translations";
      this.btnGenenrateAllMachineTranslations.UseVisualStyleBackColor = true;
      this.btnGenenrateAllMachineTranslations.Click += new System.EventHandler(this.GenenrateAllMachineTranslations);
      // 
      // btnGenenrateMachineTranslations
      // 
      this.btnGenenrateMachineTranslations.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnGenenrateMachineTranslations.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnGenenrateMachineTranslations.Location = new System.Drawing.Point(11, 23);
      this.btnGenenrateMachineTranslations.Name = "btnGenenrateMachineTranslations";
      this.btnGenenrateMachineTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnGenenrateMachineTranslations.TabIndex = 10;
      this.btnGenenrateMachineTranslations.Text = "Genenrate Translations";
      this.btnGenenrateMachineTranslations.UseVisualStyleBackColor = false;
      this.btnGenenrateMachineTranslations.Click += new System.EventHandler(this.GenenrateMachineTranslations);
      // 
      // listCultureToPopulate
      // 
      this.listCultureToPopulate.FormattingEnabled = true;
      this.listCultureToPopulate.Location = new System.Drawing.Point(11, 64);
      this.listCultureToPopulate.Name = "listCultureToPopulate";
      this.listCultureToPopulate.Size = new System.Drawing.Size(201, 28);
      this.listCultureToPopulate.TabIndex = 11;
      // 
      // grpSecondaryCultures
      // 
      this.grpSecondaryCultures.Controls.Add(this.addSecondaryCulture);
      this.grpSecondaryCultures.Controls.Add(this.listSecondaryCultures);
      this.grpSecondaryCultures.Location = new System.Drawing.Point(702, 44);
      this.grpSecondaryCultures.Name = "grpSecondaryCultures";
      this.grpSecondaryCultures.Size = new System.Drawing.Size(224, 245);
      this.grpSecondaryCultures.TabIndex = 2;
      this.grpSecondaryCultures.TabStop = false;
      this.grpSecondaryCultures.Text = "Secondary Cultures";
      // 
      // addSecondaryCulture
      // 
      this.addSecondaryCulture.Location = new System.Drawing.Point(8, 27);
      this.addSecondaryCulture.Name = "addSecondaryCulture";
      this.addSecondaryCulture.Size = new System.Drawing.Size(200, 36);
      this.addSecondaryCulture.TabIndex = 3;
      this.addSecondaryCulture.Text = "Add Culture";
      this.addSecondaryCulture.UseVisualStyleBackColor = true;
      this.addSecondaryCulture.Click += new System.EventHandler(this.AddSecondaryCulture);
      // 
      // listSecondaryCultures
      // 
      this.listSecondaryCultures.FormattingEnabled = true;
      this.listSecondaryCultures.ItemHeight = 20;
      this.listSecondaryCultures.Location = new System.Drawing.Point(9, 69);
      this.listSecondaryCultures.Name = "listSecondaryCultures";
      this.listSecondaryCultures.Size = new System.Drawing.Size(201, 164);
      this.listSecondaryCultures.TabIndex = 0;
      this.listSecondaryCultures.TabStop = false;
      this.listSecondaryCultures.UseTabStops = false;
      // 
      // menuStrip
      // 
      this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnection,
            this.menuTranslatedTables,
            this.menuSyncDataModel});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
      this.menuStrip.Size = new System.Drawing.Size(1416, 38);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuMain";
      // 
      // menuConnection
      // 
      this.menuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnect,
            this.menuDisconnect,
            this.toolStripSeparator2,
            this.menuConfigureSettings,
            this.toolStripSeparator1,
            this.exportModelAsJson});
      this.menuConnection.Name = "menuConnection";
      this.menuConnection.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
      this.menuConnection.Size = new System.Drawing.Size(153, 32);
      this.menuConnection.Text = "Dataset Connection";
      // 
      // menuConnect
      // 
      this.menuConnect.Name = "menuConnect";
      this.menuConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
      this.menuConnect.Size = new System.Drawing.Size(281, 26);
      this.menuConnect.Text = "Connect...";
      this.menuConnect.Click += new System.EventHandler(this.menuConnect_Click);
      // 
      // menuDisconnect
      // 
      this.menuDisconnect.Name = "menuDisconnect";
      this.menuDisconnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
      this.menuDisconnect.Size = new System.Drawing.Size(281, 26);
      this.menuDisconnect.Text = "Disconnect";
      this.menuDisconnect.Click += new System.EventHandler(this.menuDisconnect_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(278, 6);
      // 
      // menuConfigureSettings
      // 
      this.menuConfigureSettings.Name = "menuConfigureSettings";
      this.menuConfigureSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.menuConfigureSettings.Size = new System.Drawing.Size(281, 26);
      this.menuConfigureSettings.Text = "Configure Settings...";
      this.menuConfigureSettings.Click += new System.EventHandler(this.ConfigureSettings);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
      // 
      // exportModelAsJson
      // 
      this.exportModelAsJson.Name = "exportModelAsJson";
      this.exportModelAsJson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
      this.exportModelAsJson.Size = new System.Drawing.Size(281, 26);
      this.exportModelAsJson.Text = "Export As Model.bim";
      this.exportModelAsJson.Click += new System.EventHandler(this.exportModelAsJson_Click);
      // 
      // menuTranslatedTables
      // 
      this.menuTranslatedTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateLocalizedLabelsTable,
            this.menuAddLabelsToLocalizedLabelsTable,
            this.menuGenerateTranslatedLocalizedLabelsTable,
            this.menuGenerateTranslatedDatasetObjectNamesTable,
            this.menuGenerateTranslatedReportLabelMatrixMeasures,
            this.menuGenerateTranslatedReportLabelTableMeasures});
      this.menuTranslatedTables.Name = "menuTranslatedTables";
      this.menuTranslatedTables.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
      this.menuTranslatedTables.Size = new System.Drawing.Size(200, 32);
      this.menuTranslatedTables.Text = "Generate Translated Tables";
      // 
      // menuCreateLocalizedLabelsTable
      // 
      this.menuCreateLocalizedLabelsTable.Name = "menuCreateLocalizedLabelsTable";
      this.menuCreateLocalizedLabelsTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.menuCreateLocalizedLabelsTable.Size = new System.Drawing.Size(480, 26);
      this.menuCreateLocalizedLabelsTable.Text = "Create Localized Labels Table";
      this.menuCreateLocalizedLabelsTable.Click += new System.EventHandler(this.CreateLocalizedLabelsTable);
      // 
      // menuAddLabelsToLocalizedLabelsTable
      // 
      this.menuAddLabelsToLocalizedLabelsTable.Name = "menuAddLabelsToLocalizedLabelsTable";
      this.menuAddLabelsToLocalizedLabelsTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.menuAddLabelsToLocalizedLabelsTable.Size = new System.Drawing.Size(480, 26);
      this.menuAddLabelsToLocalizedLabelsTable.Text = "Add Labels to  Localized Labels Table...";
      this.menuAddLabelsToLocalizedLabelsTable.Click += new System.EventHandler(this.AddLocalizedLabels);
      // 
      // menuGenerateTranslatedLocalizedLabelsTable
      // 
      this.menuGenerateTranslatedLocalizedLabelsTable.Name = "menuGenerateTranslatedLocalizedLabelsTable";
      this.menuGenerateTranslatedLocalizedLabelsTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.menuGenerateTranslatedLocalizedLabelsTable.Size = new System.Drawing.Size(480, 26);
      this.menuGenerateTranslatedLocalizedLabelsTable.Text = "Generate Translated Localized Labels Table";
      this.menuGenerateTranslatedLocalizedLabelsTable.Click += new System.EventHandler(this.GenerateTranslatedLocalizedLabelsTable);
      // 
      // menuGenerateTranslatedDatasetObjectNamesTable
      // 
      this.menuGenerateTranslatedDatasetObjectNamesTable.Name = "menuGenerateTranslatedDatasetObjectNamesTable";
      this.menuGenerateTranslatedDatasetObjectNamesTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.menuGenerateTranslatedDatasetObjectNamesTable.Size = new System.Drawing.Size(480, 26);
      this.menuGenerateTranslatedDatasetObjectNamesTable.Text = "Generate Translated Dataset Object Names Table";
      this.menuGenerateTranslatedDatasetObjectNamesTable.Click += new System.EventHandler(this.GenerateTranslatedDatasetObjectNamesTable);
      // 
      // menuGenerateTranslatedReportLabelMatrixMeasures
      // 
      this.menuGenerateTranslatedReportLabelMatrixMeasures.Name = "menuGenerateTranslatedReportLabelMatrixMeasures";
      this.menuGenerateTranslatedReportLabelMatrixMeasures.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
      this.menuGenerateTranslatedReportLabelMatrixMeasures.Size = new System.Drawing.Size(480, 26);
      this.menuGenerateTranslatedReportLabelMatrixMeasures.Text = "Generate Translated Report Label Matrix Measures";
      this.menuGenerateTranslatedReportLabelMatrixMeasures.Click += new System.EventHandler(this.GenerateTranslatedReportLabelMatrixMeasures);
      // 
      // menuGenerateTranslatedReportLabelTableMeasures
      // 
      this.menuGenerateTranslatedReportLabelTableMeasures.Name = "menuGenerateTranslatedReportLabelTableMeasures";
      this.menuGenerateTranslatedReportLabelTableMeasures.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.menuGenerateTranslatedReportLabelTableMeasures.Size = new System.Drawing.Size(480, 26);
      this.menuGenerateTranslatedReportLabelTableMeasures.Text = "Generate Translated Report Label Table Measures";
      this.menuGenerateTranslatedReportLabelTableMeasures.Click += new System.EventHandler(this.GenerateTranslatedReportLabelTableMeasures);
      // 
      // menuSyncDataModel
      // 
      this.menuSyncDataModel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.menuSyncDataModel.BackColor = System.Drawing.Color.White;
      this.menuSyncDataModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.menuSyncDataModel.ForeColor = System.Drawing.SystemColors.Desktop;
      this.menuSyncDataModel.Margin = new System.Windows.Forms.Padding(4);
      this.menuSyncDataModel.Name = "menuSyncDataModel";
      this.menuSyncDataModel.Size = new System.Drawing.Size(140, 24);
      this.menuSyncDataModel.Text = "Sync Data Model";
      this.menuSyncDataModel.Click += new System.EventHandler(this.SyncDataModel);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatusBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
      this.statusStrip1.Location = new System.Drawing.Point(0, 717);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1416, 22);
      this.statusStrip1.TabIndex = 9;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // labelStatusBar
      // 
      this.labelStatusBar.Name = "labelStatusBar";
      this.labelStatusBar.Size = new System.Drawing.Size(0, 16);
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
      // 
      // toolStripStatusLabel2
      // 
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
      // 
      // contextMenuSecondaryLanguageHeader
      // 
      this.contextMenuSecondaryLanguageHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuSecondaryLanguageHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCommandDeleteSecondaryLanguage});
      this.contextMenuSecondaryLanguageHeader.Name = "contextMenuSecondaryLanguageHeader";
      this.contextMenuSecondaryLanguageHeader.Size = new System.Drawing.Size(265, 28);
      this.contextMenuSecondaryLanguageHeader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuSecondaryLanguageHeader_MouseClick);
      // 
      // menuCommandDeleteSecondaryLanguage
      // 
      this.menuCommandDeleteSecondaryLanguage.Name = "menuCommandDeleteSecondaryLanguage";
      this.menuCommandDeleteSecondaryLanguage.Size = new System.Drawing.Size(264, 24);
      this.menuCommandDeleteSecondaryLanguage.Text = "Delete Secondary Language";
      this.menuCommandDeleteSecondaryLanguage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuCommandDeleteSecondaryLanguage_MouseDown);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1416, 739);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.gridTranslations);
      this.Controls.Add(this.panel2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Translations Builder";
      this.Load += new System.EventHandler(this.onLoad);
      ((System.ComponentModel.ISupportInitialize)(this.gridTranslations)).EndInit();
      this.groupDefaultCulture.ResumeLayout(false);
      this.groupDefaultCulture.PerformLayout();
      this.groupDatasetProperties.ResumeLayout(false);
      this.groupDatasetProperties.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.grpImportExportTranslations.ResumeLayout(false);
      this.grpMachineTranslations.ResumeLayout(false);
      this.grpSecondaryCultures.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.contextMenuSecondaryLanguageHeader.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView gridTranslations;
    private OpenFileDialog dialogOpenFile;
    private GroupBox groupDefaultCulture;
    private Button btnPopulateDefaultCultureTranslations;
    private TextBox txtDefaultCulture;
    private GroupBox groupDatasetProperties;
    private Panel panel2;
    private Label lblDefaultCultureNameLabel;
    private GroupBox grpSecondaryCultures;
    private Button addSecondaryCulture;
    private ListBox listSecondaryCultures;
    private GroupBox grpMachineTranslations;
    private GroupBox grpImportExportTranslations;
    private Button btnExportTranslations;
    private Button btnImportTranslations;
    private Button btnExportTranslationsSheet;
    private ComboBox listLanguageForTransation;
    private ComboBox listCultureToPopulate;
    private Button btnGenenrateMachineTranslations;
    private TextBox txtEstimatedSize;
    private Label lblEstimatedSize;
    private TextBox txtCompatibilityLevel;
    private Label lblCompatibilityLevel;
    private TextBox txtDatasetName;
    private TextBox txtServerConnection;
    private Label lblDatasetName;
    private Label lblServerConnection;
    private MenuStrip menuStrip;
    private ToolStripMenuItem menuConnection;
    private ToolStripMenuItem menuConfigureSettings;
    private ToolStripSeparator toolStripSeparator1;
    private Button btnGenenrateAllMachineTranslations;
        private ToolStripMenuItem menuTranslatedTables;
        private Button btnFillAllEmptyTranslations;
        private ToolStripMenuItem menuCreateLocalizedLabelsTable;
        private ToolStripMenuItem menuGenerateTranslatedLocalizedLabelsTable;
        private ToolStripMenuItem menuSyncDataModel;
        private ToolStripMenuItem menuGenerateTranslatedReportLabelMatrixMeasures;
        private ToolStripMenuItem menuGenerateTranslatedReportLabelTableMeasures;
        private ToolStripMenuItem menuGenerateTranslatedDatasetObjectNamesTable;
        private Button btnFillEmptyTranslations;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelStatusBar;
        private ToolStripMenuItem menuAddLabelsToLocalizedLabelsTable;
        private ToolStripMenuItem menuConnect;
        private ToolStripMenuItem menuDisconnect;
        private ToolTip tooltipDatasetName;
        private ToolTip tooltipServiceConnection;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ContextMenuStrip contextMenuSecondaryLanguageHeader;
        private ToolStripMenuItem menuCommandDeleteSecondaryLanguage;
        private ToolStripMenuItem exportModelAsJson;
        private ToolStripSeparator toolStripSeparator2;
    }
}

