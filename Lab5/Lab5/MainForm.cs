using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private List<Samochod> listaAut = new List<Samochod>();

        Baza db = new Baza("localhost", "kacperz", "visual", "zaq1@WSX");

        private void connectBtn_Click(object sender, EventArgs e)
        {
            statusLabel.Text = db.Polacz().ToString();
            dataGrid.Rows.Clear();
            listaAut.Clear();

            MySqlCommand polecenie = db.Query("SELECT * from samochody");
            try
            {
                MySqlDataReader reader = polecenie.ExecuteReader();
                while (reader.Read())
                {
                    IDataRecord rekord = ((IDataRecord)reader);
                    Samochod nowy = Samochod.Dodaj(rekord);
                    listaAut.Add(nowy);
                    dataGrid.Rows.Add(nowy.GetGridString());
                }
                reader.Close();
            }
            catch
            {
                statusLabel.Text = "Wystapił błąd podczas wykonywania zapytania";
            }
        }

        private void disconnBtn_Click(object sender, EventArgs e)
        {
            statusLabel.Text = db.Rozlacz().ToString();
            dataGrid.Rows.Clear();
            listaAut.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddForm dodaj = new AddForm())
            {
                dodaj.ShowDialog(this);
                if (dodaj.DialogResult == DialogResult.OK)
                {
                    if (db.Polacz() == ConnectionState.Open)
                    {
                        if (dodaj.Dodany.id == null)
                        {
                            MySqlCommand polecenie = new MySqlCommand("INSERT INTO samochody(marka, model, rok_produkcji, pojemnosc_skokowa, moc_silnika, cena) VALUES(?marka,?model,?rok,?pojemnosc,?moc,?cena)", db.Polaczenie);
                            polecenie.Parameters.Add("?marka", MySqlDbType.VarChar).Value = dodaj.Dodany.marka;
                            polecenie.Parameters.Add("?model", MySqlDbType.VarChar).Value = dodaj.Dodany.model;
                            polecenie.Parameters.Add("?rok", MySqlDbType.Int16).Value = dodaj.Dodany.rok_produkcji;
                            polecenie.Parameters.Add("?pojemnosc", MySqlDbType.Int16).Value = dodaj.Dodany.pojemnosc;
                            polecenie.Parameters.Add("?moc", MySqlDbType.Int16).Value = dodaj.Dodany.moc_silnika;
                            polecenie.Parameters.Add("?cena", MySqlDbType.Decimal).Value = dodaj.Dodany.cena;
                            try
                            {
                                polecenie.ExecuteNonQuery();
                                dodaj.Dodany.id = (int)polecenie.LastInsertedId;
                                listaAut.Add(dodaj.Dodany);
                                dataGrid.Rows.Add(dodaj.Dodany.GetGridString());
                            }
                            catch (Exception ex)
                            {
                                statusLabel.Text = "Wystapil blad podczas dodawania " + ex.Message;
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        statusLabel.Text = "Nie można dodać - brak połączenia z bazą";
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 1)
            {
                statusLabel.Text = "Nie mozna edytowac wiecej niz jeden element";
            }
            else if (dataGrid.SelectedRows.Count == 1)
            {
                int carid = int.Parse(dataGrid.SelectedRows[0].Cells["id"].Value.ToString());
                Samochod edit = null;
                foreach (Samochod s in listaAut)
                {
                    if (s.id == carid)
                    {
                        edit = s;
                        break;
                    }
                }
                using (AddForm dodaj = new AddForm(edit))
                {
                    dodaj.Show(this);
                    if (dodaj.DialogResult == DialogResult.OK)
                    {
                        if (db.Polacz() == ConnectionState.Open)
                        {
                            MySqlCommand polecenie = new MySqlCommand("UPDATE samochody set marka=?marka, model=?model,rok_produkcji=?rok,pojemnosc_skokowa=?pojemnosc,moc_silnika=?moc,cena=?cena where id=?id");
                            polecenie.Parameters.Add("?marka", MySqlDbType.VarChar).Value = edit.marka;
                            polecenie.Parameters.Add("?model", MySqlDbType.VarChar).Value = edit.model;
                            polecenie.Parameters.Add("?rok", MySqlDbType.Int16).Value = edit.rok_produkcji;
                            polecenie.Parameters.Add("?pojemnosc", MySqlDbType.Int16).Value = edit.pojemnosc;
                            polecenie.Parameters.Add("?moc", MySqlDbType.Int16).Value = edit.moc_silnika;
                            polecenie.Parameters.Add("?cena", MySqlDbType.Decimal).Value = edit.cena;
                            polecenie.Parameters.Add("?id", MySqlDbType.Int16).Value = edit.id;
                            try
                            {
                                polecenie.ExecuteNonQuery();
                                int rowIndex = -1;
                                foreach (DataGridViewRow row in dataGrid.Rows)
                                {
                                    if (row.Cells[0].Value.ToString() == edit.ToString())
                                    {
                                        rowIndex = row.Index;
                                        break;
                                    }
                                }
                                dataGrid.Rows.RemoveAt(rowIndex);
                                dataGrid.Rows.Insert(rowIndex, edit.GetGridString());
                            }
                            catch (Exception ex)
                            {
                                statusLabel.Text = "Wystapil blad podczas edycji " + ex.Message;
                            }
                        }
                    }
                }
            }
        }

    }
}
