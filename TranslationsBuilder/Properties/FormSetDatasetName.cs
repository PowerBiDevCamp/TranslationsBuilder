using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationsBuilder {
  public partial class FormSetDatasetName : Form {

    public FormSetDatasetName() {
      InitializeComponent();
    }

    public string DatasetName {
      get {
        return txtDatasetName.Text;
      }
      set {
        txtDatasetName.Text = value;
      }
    }

    private void Save(object sender, EventArgs e) {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void Cancel(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
