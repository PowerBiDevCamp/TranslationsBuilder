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

    public string getLanguage() {
      return ((Language)listCultures.SelectedItem).LanguageTag;
    }

    private void AddCultureDialog_Load(object sender, EventArgs e) {

      var model = TranslationsManager.model;
      var cultures = model.Cultures;

      foreach (var language in SupportedLanguages.AllLangauges) {
        if (!cultures.ContainsName(language.Key)) {
          listCultures.Items.Add(language.Value);
        }
      }

      if (listCultures.Items.Count > 0) {
        listCultures.SelectedIndex = 0;
      }

    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void btnAddCulture_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.OK;
      this.Close();

      //
    }
  }
}
