
namespace Rendszamok_Beadando {
  partial class JatekForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JatekForm));
      this.rendszamPictureBox = new System.Windows.Forms.PictureBox();
      this.rendszamLabel = new System.Windows.Forms.Label();
      this.kovetkezoButton = new System.Windows.Forms.Button();
      this.tippelekButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tippTextBox = new System.Windows.Forms.TextBox();
      this.johetAtippelesButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.rendszamPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // rendszamPictureBox
      // 
      this.rendszamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rendszamPictureBox.Image")));
      this.rendszamPictureBox.Location = new System.Drawing.Point(12, 12);
      this.rendszamPictureBox.Name = "rendszamPictureBox";
      this.rendszamPictureBox.Size = new System.Drawing.Size(776, 190);
      this.rendszamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.rendszamPictureBox.TabIndex = 1;
      this.rendszamPictureBox.TabStop = false;
      // 
      // rendszamLabel
      // 
      this.rendszamLabel.BackColor = System.Drawing.Color.White;
      this.rendszamLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.rendszamLabel.Location = new System.Drawing.Point(120, 25);
      this.rendszamLabel.Name = "rendszamLabel";
      this.rendszamLabel.Size = new System.Drawing.Size(655, 160);
      this.rendszamLabel.TabIndex = 2;
      this.rendszamLabel.Text = "IMK-705";
      this.rendszamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kovetkezoButton
      // 
      this.kovetkezoButton.Location = new System.Drawing.Point(325, 250);
      this.kovetkezoButton.Name = "kovetkezoButton";
      this.kovetkezoButton.Size = new System.Drawing.Size(150, 50);
      this.kovetkezoButton.TabIndex = 3;
      this.kovetkezoButton.Text = "KÖVETKEZŐ";
      this.kovetkezoButton.UseVisualStyleBackColor = true;
      this.kovetkezoButton.Click += new System.EventHandler(this.kovetkezoButton_Click);
      // 
      // tippelekButton
      // 
      this.tippelekButton.Location = new System.Drawing.Point(325, 250);
      this.tippelekButton.Name = "tippelekButton";
      this.tippelekButton.Size = new System.Drawing.Size(150, 50);
      this.tippelekButton.TabIndex = 4;
      this.tippelekButton.Text = "TIPPELEK";
      this.tippelekButton.UseVisualStyleBackColor = true;
      this.tippelekButton.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(57, 337);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 20);
      this.label1.TabIndex = 5;
      // 
      // tippTextBox
      // 
      this.tippTextBox.Location = new System.Drawing.Point(12, 12);
      this.tippTextBox.Multiline = true;
      this.tippTextBox.Name = "tippTextBox";
      this.tippTextBox.Size = new System.Drawing.Size(776, 190);
      this.tippTextBox.TabIndex = 6;
      this.tippTextBox.Visible = false;
      // 
      // johetAtippelesButton
      // 
      this.johetAtippelesButton.Location = new System.Drawing.Point(325, 250);
      this.johetAtippelesButton.Name = "johetAtippelesButton";
      this.johetAtippelesButton.Size = new System.Drawing.Size(150, 50);
      this.johetAtippelesButton.TabIndex = 7;
      this.johetAtippelesButton.Text = "JÖHET A TIPPELÉS!";
      this.johetAtippelesButton.UseVisualStyleBackColor = true;
      this.johetAtippelesButton.Visible = false;
      this.johetAtippelesButton.Click += new System.EventHandler(this.johetAtippelesButton_Click);
      // 
      // JatekForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.johetAtippelesButton);
      this.Controls.Add(this.tippTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tippelekButton);
      this.Controls.Add(this.kovetkezoButton);
      this.Controls.Add(this.rendszamLabel);
      this.Controls.Add(this.rendszamPictureBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "JatekForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rendszámok";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JatekForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.rendszamPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox rendszamPictureBox;
    private System.Windows.Forms.Label rendszamLabel;
    private System.Windows.Forms.Button kovetkezoButton;
    private System.Windows.Forms.Button tippelekButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tippTextBox;
    private System.Windows.Forms.Button johetAtippelesButton;
  }
}