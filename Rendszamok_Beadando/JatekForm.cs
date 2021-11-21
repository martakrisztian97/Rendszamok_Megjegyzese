using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendszamok_Beadando {

  public partial class JatekForm : Form {

    public int Mennyit { get; set; }
    
    //String[] rendszamok;
    List<String> rendszamok = new List<String>();
    int kattint = 0;

    public String rendszamSorsol() {
      String rendszam = "";
      Random rand = new Random();
      char betu1 = (char)rand.Next(65, 91);
      char betu2 = (char)rand.Next(65, 91);
      char betu3 = (char)rand.Next(65, 91);
      int szam1 = rand.Next(10);
      int szam2 = rand.Next(10);
      int szam3 = rand.Next(10);
      rendszam += betu1+""+betu2+betu3+"-"+szam1+szam2+szam3;
      return rendszam;
    }

    public JatekForm() {
      InitializeComponent();
    }

    public JatekForm(int mennyit) {
      InitializeComponent();
      this.Mennyit = mennyit;
      rendszamok.Add(rendszamSorsol());
      rendszamLabel.Text = rendszamok[0];
      // teszt
      label1.Text += rendszamok[0]+"\n"; // teszt
      if (Mennyit == 1) {
        kovetkezoButton.Visible = false;
        johetAtippelesButton.Visible = true;
      }
    }

    private void kovetkezoButton_Click(object sender, EventArgs e) {
      /*kattint++;

      if (Mennyit == 1) {
        kovetkezoButton.Visible = false;
        rendszamPictureBox.Visible = false;
        rendszamLabel.Visible = false;
        tippTextBox.Visible = true;
        tippelekButton.Visible = true;
      }

      if (Mennyit != 1) {
        rendszamok[kattint] = rendszamSorsol();
        rendszamLabel.Text = rendszamok[kattint];
        label1.Text += rendszamok[kattint]+"\n";
      }

      if (kattint == Mennyit-1) {
        kovetkezoButton.Text = "JÖHET A TIPPELÉS!";
      }

      // Ha megkaptunk minden rendszámot.
      if (kattint == Mennyit) {
        kovetkezoButton.Visible = false;
        rendszamPictureBox.Visible = false;
        rendszamLabel.Visible = false;
        tippTextBox.Visible = true;
        tippelekButton.Visible = true;
      }*/

      if (rendszamok.Count < Mennyit) {
        int i = rendszamok.Count;
        rendszamok.Add(rendszamSorsol());
        rendszamLabel.Text = rendszamok[i];
        label1.Text += rendszamok[i]+"\n";
      }

      if (rendszamok.Count == Mennyit) {
        johetAtippelesButton.Visible = true;
      }
    }

    private void johetAtippelesButton_Click(object sender, EventArgs e) {
      kovetkezoButton.Visible = false;
      rendszamPictureBox.Visible = false;
      rendszamLabel.Visible = false;
      johetAtippelesButton.Visible = false;
      tippTextBox.Visible = true;
      tippelekButton.Visible = true;
    }

    
    private void JatekForm_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }

    private void tippTextBox_TextChanged(object sender, EventArgs e) {
      if (tippTextBox.Text.Length > 7) {
        MessageBox.Show("Maximum 7 karakter írható be!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        tippTextBox.Text = tippTextBox.Text.Substring(0, 7);
        tippTextBox.SelectionStart = 7;
      }
    }
  }
}
