
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
      this.tippTextBox = new System.Windows.Forms.TextBox();
      this.johetAtippelesButton = new System.Windows.Forms.Button();
      this.timerLabel = new System.Windows.Forms.Label();
      this.ertekelesLabel = new System.Windows.Forms.Label();
      this.ujJatekButton = new System.Windows.Forms.Button();
      this.kilepesButton = new System.Windows.Forms.Button();
      this.tajekoztatoLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.rendszamPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // rendszamPictureBox
      // 
      this.rendszamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rendszamPictureBox.Image")));
      this.rendszamPictureBox.Location = new System.Drawing.Point(12, 50);
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
      this.rendszamLabel.Location = new System.Drawing.Point(120, 63);
      this.rendszamLabel.Name = "rendszamLabel";
      this.rendszamLabel.Size = new System.Drawing.Size(655, 160);
      this.rendszamLabel.TabIndex = 2;
      this.rendszamLabel.Text = "IMK-705";
      this.rendszamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kovetkezoButton
      // 
      this.kovetkezoButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.kovetkezoButton.Location = new System.Drawing.Point(325, 300);
      this.kovetkezoButton.Name = "kovetkezoButton";
      this.kovetkezoButton.Size = new System.Drawing.Size(150, 50);
      this.kovetkezoButton.TabIndex = 3;
      this.kovetkezoButton.Text = "KÖVETKEZŐ";
      this.kovetkezoButton.UseVisualStyleBackColor = true;
      this.kovetkezoButton.Click += new System.EventHandler(this.kovetkezoButton_Click);
      // 
      // tippelekButton
      // 
      this.tippelekButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.tippelekButton.Location = new System.Drawing.Point(325, 300);
      this.tippelekButton.Name = "tippelekButton";
      this.tippelekButton.Size = new System.Drawing.Size(150, 50);
      this.tippelekButton.TabIndex = 4;
      this.tippelekButton.Text = "TIPPELEK";
      this.tippelekButton.UseVisualStyleBackColor = true;
      this.tippelekButton.Visible = false;
      this.tippelekButton.Click += new System.EventHandler(this.tippelekButton_Click);
      // 
      // tippTextBox
      // 
      this.tippTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tippTextBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tippTextBox.Location = new System.Drawing.Point(12, 53);
      this.tippTextBox.Multiline = true;
      this.tippTextBox.Name = "tippTextBox";
      this.tippTextBox.Size = new System.Drawing.Size(776, 170);
      this.tippTextBox.TabIndex = 6;
      this.tippTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tippTextBox.Visible = false;
      this.tippTextBox.TextChanged += new System.EventHandler(this.tippTextBox_TextChanged);
      // 
      // johetAtippelesButton
      // 
      this.johetAtippelesButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.johetAtippelesButton.Location = new System.Drawing.Point(325, 300);
      this.johetAtippelesButton.Name = "johetAtippelesButton";
      this.johetAtippelesButton.Size = new System.Drawing.Size(150, 50);
      this.johetAtippelesButton.TabIndex = 7;
      this.johetAtippelesButton.Text = "JÖHET A TIPPELÉS!";
      this.johetAtippelesButton.UseVisualStyleBackColor = true;
      this.johetAtippelesButton.Visible = false;
      this.johetAtippelesButton.Click += new System.EventHandler(this.johetAtippelesButton_Click);
      // 
      // timerLabel
      // 
      this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.timerLabel.Location = new System.Drawing.Point(12, 250);
      this.timerLabel.Name = "timerLabel";
      this.timerLabel.Size = new System.Drawing.Size(125, 50);
      this.timerLabel.TabIndex = 10;
      this.timerLabel.Text = "00:00:00";
      this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ertekelesLabel
      // 
      this.ertekelesLabel.BackColor = System.Drawing.SystemColors.Control;
      this.ertekelesLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ertekelesLabel.Location = new System.Drawing.Point(250, 12);
      this.ertekelesLabel.Name = "ertekelesLabel";
      this.ertekelesLabel.Size = new System.Drawing.Size(300, 190);
      this.ertekelesLabel.TabIndex = 11;
      this.ertekelesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ertekelesLabel.Visible = false;
      // 
      // ujJatekButton
      // 
      this.ujJatekButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ujJatekButton.Location = new System.Drawing.Point(250, 346);
      this.ujJatekButton.Name = "ujJatekButton";
      this.ujJatekButton.Size = new System.Drawing.Size(140, 50);
      this.ujJatekButton.TabIndex = 12;
      this.ujJatekButton.Text = "ÚJ JÁTÉK!";
      this.ujJatekButton.UseVisualStyleBackColor = true;
      this.ujJatekButton.Visible = false;
      this.ujJatekButton.Click += new System.EventHandler(this.ujJatekButton_Click);
      // 
      // kilepesButton
      // 
      this.kilepesButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.kilepesButton.Location = new System.Drawing.Point(400, 346);
      this.kilepesButton.Name = "kilepesButton";
      this.kilepesButton.Size = new System.Drawing.Size(140, 50);
      this.kilepesButton.TabIndex = 13;
      this.kilepesButton.Text = "KILÉPÉS";
      this.kilepesButton.UseVisualStyleBackColor = true;
      this.kilepesButton.Visible = false;
      this.kilepesButton.Click += new System.EventHandler(this.kilepesButton_Click);
      // 
      // tajekoztatoLabel
      // 
      this.tajekoztatoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.tajekoztatoLabel.Location = new System.Drawing.Point(0, 0);
      this.tajekoztatoLabel.Name = "tajekoztatoLabel";
      this.tajekoztatoLabel.Size = new System.Drawing.Size(800, 47);
      this.tajekoztatoLabel.TabIndex = 14;
      this.tajekoztatoLabel.Text = "1. rendszám";
      this.tajekoztatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.tajekoztatoLabel.Visible = false;
      // 
      // JatekForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tajekoztatoLabel);
      this.Controls.Add(this.kilepesButton);
      this.Controls.Add(this.ujJatekButton);
      this.Controls.Add(this.ertekelesLabel);
      this.Controls.Add(this.timerLabel);
      this.Controls.Add(this.johetAtippelesButton);
      this.Controls.Add(this.tippTextBox);
      this.Controls.Add(this.tippelekButton);
      this.Controls.Add(this.kovetkezoButton);
      this.Controls.Add(this.rendszamLabel);
      this.Controls.Add(this.rendszamPictureBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "JatekForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rendszám memóriajáték";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JatekForm_FormClosed);
      this.Load += new System.EventHandler(this.JatekForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.rendszamPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox rendszamPictureBox;
    private System.Windows.Forms.Label rendszamLabel;
    private System.Windows.Forms.Button kovetkezoButton;
    private System.Windows.Forms.Button tippelekButton;
    private System.Windows.Forms.TextBox tippTextBox;
    private System.Windows.Forms.Button johetAtippelesButton;
    private System.Windows.Forms.Label timerLabel;
    private System.Windows.Forms.Label ertekelesLabel;
    private System.Windows.Forms.Button ujJatekButton;
    private System.Windows.Forms.Button kilepesButton;
    private System.Windows.Forms.Label tajekoztatoLabel;
  }
}