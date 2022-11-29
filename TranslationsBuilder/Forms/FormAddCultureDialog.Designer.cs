
namespace TranslationsBuilder {
  partial class FormAddCultureDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCultureDialog));
      this.btnAddCulture = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.listCultures = new System.Windows.Forms.ListBox();
      this.chkShowAllLanguages = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnAddCulture
      // 
      this.btnAddCulture.Location = new System.Drawing.Point(261, 17);
      this.btnAddCulture.Name = "btnAddCulture";
      this.btnAddCulture.Size = new System.Drawing.Size(164, 37);
      this.btnAddCulture.TabIndex = 0;
      this.btnAddCulture.Text = "Add Language";
      this.btnAddCulture.UseVisualStyleBackColor = true;
      this.btnAddCulture.Click += new System.EventHandler(this.btnAddCulture_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(261, 66);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(164, 40);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // listCultures
      // 
      this.listCultures.FormattingEnabled = true;
      this.listCultures.ItemHeight = 20;
      this.listCultures.Location = new System.Drawing.Point(12, 12);
      this.listCultures.Name = "listCultures";
      this.listCultures.Size = new System.Drawing.Size(229, 384);
      this.listCultures.Sorted = true;
      this.listCultures.TabIndex = 2;
      // 
      // chkShowAllLanguages
      // 
      this.chkShowAllLanguages.AutoSize = true;
      this.chkShowAllLanguages.Location = new System.Drawing.Point(261, 122);
      this.chkShowAllLanguages.Name = "chkShowAllLanguages";
      this.chkShowAllLanguages.Size = new System.Drawing.Size(164, 24);
      this.chkShowAllLanguages.TabIndex = 3;
      this.chkShowAllLanguages.Text = "Show All Languages";
      this.chkShowAllLanguages.UseVisualStyleBackColor = true;
      this.chkShowAllLanguages.CheckedChanged += new System.EventHandler(this.chkShowAllLanguages_CheckedChanged);
      // 
      // FormAddCultureDialog
      // 
      this.AcceptButton = this.btnAddCulture;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(446, 407);
      this.Controls.Add(this.chkShowAllLanguages);
      this.Controls.Add(this.listCultures);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAddCulture);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormAddCultureDialog";
      this.Text = "Add Language";
      this.Load += new System.EventHandler(this.AddCultureDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAddCulture;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.ListBox listCultures;
        private System.Windows.Forms.CheckBox chkShowAllLanguages;
    }
}