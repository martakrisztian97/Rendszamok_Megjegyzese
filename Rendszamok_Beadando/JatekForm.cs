using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Rendszamok_Beadando {

  public partial class JatekForm : Form {

    public int Mennyit { get; set; }
    
    List<String> rendszamok = new List<String>();
    List<String> tippek = new List<String>();
    System.Timers.Timer t;
    int h, m, s;

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

    public void ertekeles() {
      String felhasznaltIdo;
      int helyes = 0;
      for (int i = 0; i < Mennyit; i++) {
        if (rendszamok[i].Equals(tippek[i])) {
          helyes++;
        }
      }
      float szazalek = (float)helyes/(float)Mennyit;
      felhasznaltIdo = timerLabel.Text;
      ertekelesLabel.Text = "Rendszámok: "+Mennyit+" db";
      ertekelesLabel.Text += "\nTalálat: "+helyes+" db";
      ertekelesLabel.Text += "\nTalálati arány: "+szazalek*100+"%";
      ertekelesLabel.Text += "\nFelhasznált idő: "+felhasznaltIdo;
    }

    public JatekForm() {
      InitializeComponent();
    }

    public JatekForm(int mennyit) {
      InitializeComponent();
      this.Mennyit = mennyit;
      rendszamok.Add(rendszamSorsol());
      rendszamLabel.Text = rendszamok[0];
      if (Mennyit == 1) {
        kovetkezoButton.Visible = false;
        johetAtippelesButton.Visible = true;
      }
      tajekoztatoLabel.Visible = true;
    }

    private void kovetkezoButton_Click(object sender, EventArgs e) {
      if (rendszamok.Count < Mennyit) {
        int i = rendszamok.Count;
        rendszamok.Add(rendszamSorsol());
        rendszamLabel.Text = rendszamok[i];
        tajekoztatoLabel.Text = (i+1)+". rendszám";
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
      tippTextBox.Focus();
      tippelekButton.Visible = true;
      tajekoztatoLabel.Text = "Kérem írja be az 1. rendszámot!";
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

    private void tippelekButton_Click(object sender, EventArgs e) {
      int kattint = 1;
      kattint++;
      if (tippek.Count < Mennyit) {
        int i = tippek.Count;
        tippek.Add(tippTextBox.Text);
        tippTextBox.Text = "";
        if (i+1 < Mennyit) {
          tajekoztatoLabel.Text = "Kérem írja be az "+(tippek.Count+1)+". rendszámot!";
        }
        if (rendszamok[i].Equals(tippek[i])) {
          MessageBox.Show("Helyes tipp!", "Értékelés", MessageBoxButtons.OK, MessageBoxIcon.Information);
          tippTextBox.Focus();
        } else {
          MessageBox.Show("Hibás tipp! A helyes rendszám: "+rendszamok[i], "Értékelés", MessageBoxButtons.OK, MessageBoxIcon.Error);
          tippTextBox.Focus();
        }
      }

      if (tippek.Count == Mennyit) {
        tippTextBox.Visible = false;
        tippelekButton.Visible = false;
        tajekoztatoLabel.Visible = false;
        t.Stop();
        timerLabel.Visible = false;
        ertekelesLabel.Visible = true;
        ujJatekButton.Visible = true;
        kilepesButton.Visible = true;
        ertekeles();
      }
    }

    private void kilepesButton_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void ujJatekButton_Click(object sender, EventArgs e) {
      kerdesForm ujJatekForm = new kerdesForm();
      ujJatekForm.Show();
      this.Hide();
    }

    private void JatekForm_Load(object sender, EventArgs e) {
      t = new System.Timers.Timer();
      t.Interval = 1000; // 1 másodperc
      t.Elapsed += OnTimeEvent;
      t.Start();
    }

    private void OnTimeEvent(object sender, ElapsedEventArgs e) {
      Invoke(new Action(() =>
      {
        s += 1;
        if (s == 60) {
          s = 0;
          m += 1;
        }

        if (m == 60) {
          m = 0;
          h += 1;
        }
        timerLabel.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
      }));
    }
  }
}
