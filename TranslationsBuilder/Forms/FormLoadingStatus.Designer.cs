
namespace TranslationsBuilder {
  partial class FormLoadingStatus {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadingStatus));
      this.imageSpinner = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblObjectName = new System.Windows.Forms.Label();
      this.lblObjectNameLabel = new System.Windows.Forms.Label();
      this.lblTranslatedText = new System.Windows.Forms.Label();
      this.lblOriginalText = new System.Windows.Forms.Label();
      this.lblTranslationType = new System.Windows.Forms.Label();
      this.llblTranslatedTextLabel = new System.Windows.Forms.Label();
      this.lblOriginalTextLabel = new System.Windows.Forms.Label();
      this.lblTranslationTypeLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.imageSpinner)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageSpinner
      // 
      this.imageSpinner.BackColor = System.Drawing.Color.Transparent;
      this.imageSpinner.Image = global::TranslationsBuilder.Properties.Resources.loading;
      this.imageSpinner.Location = new System.Drawing.Point(27, 45);
      this.imageSpinner.Name = "imageSpinner";
      this.imageSpinner.Size = new System.Drawing.Size(151, 146);
      this.imageSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.imageSpinner.TabIndex = 1;
      this.imageSpinner.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
      this.groupBox1.Controls.Add(this.lblObjectName);
      this.groupBox1.Controls.Add(this.lblObjectNameLabel);
      this.groupBox1.Controls.Add(this.lblTranslatedText);
      this.groupBox1.Controls.Add(this.lblOriginalText);
      this.groupBox1.Controls.Add(this.lblTranslationType);
      this.groupBox1.Controls.Add(this.llblTranslatedTextLabel);
      this.groupBox1.Controls.Add(this.lblOriginalTextLabel);
      this.groupBox1.Controls.Add(this.lblTranslationTypeLabel);
      this.groupBox1.Controls.Add(this.imageSpinner);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(810, 223);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Generating machine translations";
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // lblObjectName
      // 
      this.lblObjectName.BackColor = System.Drawing.SystemColors.Info;
      this.lblObjectName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblObjectName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblObjectName.Location = new System.Drawing.Point(355, 77);
      this.lblObjectName.Name = "lblObjectName";
      this.lblObjectName.Size = new System.Drawing.Size(415, 33);
      this.lblObjectName.TabIndex = 9;
      this.lblObjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblObjectNameLabel
      // 
      this.lblObjectNameLabel.AutoSize = true;
      this.lblObjectNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblObjectNameLabel.Location = new System.Drawing.Point(211, 84);
      this.lblObjectNameLabel.Name = "lblObjectNameLabel";
      this.lblObjectNameLabel.Size = new System.Drawing.Size(115, 23);
      this.lblObjectNameLabel.TabIndex = 8;
      this.lblObjectNameLabel.Text = "Object Name:";
      // 
      // lblTranslatedText
      // 
      this.lblTranslatedText.BackColor = System.Drawing.SystemColors.Info;
      this.lblTranslatedText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblTranslatedText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblTranslatedText.Location = new System.Drawing.Point(355, 161);
      this.lblTranslatedText.Name = "lblTranslatedText";
      this.lblTranslatedText.Size = new System.Drawing.Size(415, 33);
      this.lblTranslatedText.TabIndex = 7;
      this.lblTranslatedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblOriginalText
      // 
      this.lblOriginalText.BackColor = System.Drawing.SystemColors.Info;
      this.lblOriginalText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblOriginalText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblOriginalText.Location = new System.Drawing.Point(355, 119);
      this.lblOriginalText.Name = "lblOriginalText";
      this.lblOriginalText.Size = new System.Drawing.Size(415, 33);
      this.lblOriginalText.TabIndex = 6;
      this.lblOriginalText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTranslationType
      // 
      this.lblTranslationType.BackColor = System.Drawing.SystemColors.Info;
      this.lblTranslationType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblTranslationType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblTranslationType.Location = new System.Drawing.Point(355, 35);
      this.lblTranslationType.Name = "lblTranslationType";
      this.lblTranslationType.Size = new System.Drawing.Size(415, 33);
      this.lblTranslationType.TabIndex = 5;
      this.lblTranslationType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblTranslationType.Click += new System.EventHandler(this.label1_Click);
      // 
      // llblTranslatedTextLabel
      // 
      this.llblTranslatedTextLabel.AutoSize = true;
      this.llblTranslatedTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.llblTranslatedTextLabel.Location = new System.Drawing.Point(211, 168);
      this.llblTranslatedTextLabel.Name = "llblTranslatedTextLabel";
      this.llblTranslatedTextLabel.Size = new System.Drawing.Size(127, 23);
      this.llblTranslatedTextLabel.TabIndex = 4;
      this.llblTranslatedTextLabel.Text = "Translated Text:";
      // 
      // lblOriginalTextLabel
      // 
      this.lblOriginalTextLabel.AutoSize = true;
      this.lblOriginalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblOriginalTextLabel.Location = new System.Drawing.Point(211, 126);
      this.lblOriginalTextLabel.Name = "lblOriginalTextLabel";
      this.lblOriginalTextLabel.Size = new System.Drawing.Size(109, 23);
      this.lblOriginalTextLabel.TabIndex = 3;
      this.lblOriginalTextLabel.Text = "Original Text:";
      // 
      // lblTranslationTypeLabel
      // 
      this.lblTranslationTypeLabel.AutoSize = true;
      this.lblTranslationTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblTranslationTypeLabel.Location = new System.Drawing.Point(211, 42);
      this.lblTranslationTypeLabel.Name = "lblTranslationTypeLabel";
      this.lblTranslationTypeLabel.Size = new System.Drawing.Size(137, 23);
      this.lblTranslationTypeLabel.TabIndex = 2;
      this.lblTranslationTypeLabel.Text = "Translation Type:";
      this.lblTranslationTypeLabel.Click += new System.EventHandler(this.lblTranslationTypeLabel_Click);
      // 
      // FormLoadingStatus
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(835, 248);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormLoadingStatus";
      this.Text = "Calling to Microsoft Translation Services";
      this.Load += new System.EventHandler(this.frmLoadingStatus_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imageSpinner)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.PictureBox imageSpinner;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblTranslationTypeLabel;
    private System.Windows.Forms.Label lblTranslationType;
    private System.Windows.Forms.Label llblTranslatedTextLabel;
    private System.Windows.Forms.Label lblOriginalTextLabel;
    private System.Windows.Forms.Label lblTranslatedText;
    private System.Windows.Forms.Label lblOriginalText;
    private System.Windows.Forms.Label lblObjectName;
    private System.Windows.Forms.Label lblObjectNameLabel;
  }
}