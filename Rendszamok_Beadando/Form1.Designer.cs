
namespace Rendszamok_Beadando {
  partial class kerdesForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kerdesForm));
      this.label1 = new System.Windows.Forms.Label();
      this.mennyitTextBox = new System.Windows.Forms.TextBox();
      this.inditasButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(401, 88);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hány rendszámot akar megjegyezni?\r\n(1-5)";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // mennyitTextBox
      // 
      this.mennyitTextBox.Location = new System.Drawing.Point(150, 91);
      this.mennyitTextBox.Multiline = true;
      this.mennyitTextBox.Name = "mennyitTextBox";
      this.mennyitTextBox.Size = new System.Drawing.Size(100, 30);
      this.mennyitTextBox.TabIndex = 1;
      this.mennyitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mennyitTextBox.TextChanged += new System.EventHandler(this.mennyitTextBox_TextChanged);
      // 
      // inditasButton
      // 
      this.inditasButton.Location = new System.Drawing.Point(150, 141);
      this.inditasButton.Name = "inditasButton";
      this.inditasButton.Size = new System.Drawing.Size(100, 35);
      this.inditasButton.TabIndex = 2;
      this.inditasButton.Text = "Indítás";
      this.inditasButton.UseVisualStyleBackColor = true;
      this.inditasButton.Click += new System.EventHandler(this.inditasButton_Click);
      // 
      // kerdesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 203);
      this.Controls.Add(this.inditasButton);
      this.Controls.Add(this.mennyitTextBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "kerdesForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rendszámok";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox mennyitTextBox;
    private System.Windows.Forms.Button inditasButton;
  }
}

