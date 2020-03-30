using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Samochod
    {
        public int? id;
        public string marka;
        public string model;
        public int rok_produkcji;
        public int pojemnosc;
        public int moc_silnika;
        public decimal cena;

        public string[] GetGridString()
        { 
            return new string[] {id.ToString(), marka, model, rok_produkcji.ToString(), pojemnosc.ToString(), moc_silnika.ToString(), cena.ToString()};
        }

        public static Samochod Dodaj(IDataRecord rekord)
        {
            return new Samochod
            {
                id = (int)rekord["id"],
                marka = (string)rekord["marka"],
                model = (string)rekord["model"],
                rok_produkcji = (int)rekord["rok_produkcji"],
                pojemnosc = (int)rekord["pojemnosc_skokowa"],
                moc_silnika = (int)rekord["moc_silnika"],
                cena = (decimal)rekord["cena"]
            };
        }
    }
}
