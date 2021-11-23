using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendszamok_Beadando {
  public partial class kerdesForm : System.Windows.Forms.Form {
    public kerdesForm() {
      InitializeComponent();
    }

    private void inditasButton_Click(object sender, EventArgs e) {
      try {
        int mennyit = int.Parse(mennyitTextBox.Text);
        this.Hide();
        JatekForm jatekForm = new JatekForm(mennyit);
        jatekForm.Show();
      } catch {
        if (mennyitTextBox.Text == "") {
          MessageBox.Show("Mező kitöltése kötelező!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void mennyitTextBox_TextChanged(object sender, EventArgs e) {
      try {
        int mennyit = int.Parse(mennyitTextBox.Text);
        if (mennyit < 1 || mennyit > 5) {
          MessageBox.Show("1 és 5 közötti egész számot adjon meg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          mennyitTextBox.Text = "";
        }
      } catch (FormatException) {
        if (mennyitTextBox.Text != "") {
          MessageBox.Show("Egész számot adjon meg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        mennyitTextBox.Text = "";
      }
    }

    private void mennyitTextBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        try {
          int mennyit = int.Parse(mennyitTextBox.Text);
          this.Hide();
          JatekForm jatekForm = new JatekForm(mennyit);
          jatekForm.Mennyit = mennyit;
          jatekForm.Show();
        } catch {
          if (mennyitTextBox.Text == "") {
            MessageBox.Show("Mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void kerdesForm_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }
  }
}
