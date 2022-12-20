using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationsBuilder.Models;
using TranslationsBuilder.Services;

namespace TranslationsBuilder {
  public partial class FormAddCultureDialog : Form {

    public FormAddCultureDialog() {
      InitializeComponent();
    }

    public string[] getLanguages() {
      List<string> Languages = new List<string>();
      foreach(object item in listCultures.SelectedItems) {
        Languages.Add(((Language)item).LanguageTag);
      }
      return Languages.ToArray();
    }

    private void PopulateListBox() {

      listCultures.Items.Clear();

      var model = TranslationsManager.model;
      var cultures = model.Cultures;

      Dictionary<string, Language> languages;

      if (chkShowAllLanguages.Checked) {
        languages = SupportedLanguages.AllLangauges;
      }
      else {
        languages = SupportedLanguages.GetCommonLangauges();
      }

      foreach (var language in languages) {
        if (!cultures.ContainsName(language.Key)) {
          listCultures.Items.Add(language.Value);
        }
      }

      if (listCultures.Items.Count > 0) {
        listCultures.SelectedIndex = 0;
      }
    }

    private void AddCultureDialog_Load(object sender, EventArgs e) {
      PopulateListBox();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void btnAddCulture_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void chkShowAllLanguages_CheckedChanged(object sender, EventArgs e) {
      PopulateListBox();
    }
  }
}
