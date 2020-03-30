using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class AddForm : Form
    {
        public Samochod Dodany = new Samochod();

        public AddForm()
        {
            InitializeComponent();
            Dodany.id = null;
        }

        public AddForm(Samochod car)
        {
            Dodany = car;
            markaBox.Text = Dodany.marka;
            modelBox.Text = Dodany.model;
            pojemBox.Text = Dodany.pojemnosc.ToString();
            cenaBox.Text = Dodany.cena.ToString();
            mocBox.Text = Dodany.moc_silnika.ToString();
            rokBox.Text = Dodany.rok_produkcji.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dodany.marka = markaBox.Text;
            Dodany.model = modelBox.Text;
            try
            {
                Dodany.rok_produkcji = int.Parse(rokBox.Text);
                Dodany.pojemnosc = int.Parse(pojemBox.Text);
                Dodany.moc_silnika = int.Parse(mocBox.Text);
                Dodany.cena = decimal.Parse(cenaBox.Text);
            }
            catch
            {
                infoLabel.Text = "Wystąpił błąd podczas konwersji danych";
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
