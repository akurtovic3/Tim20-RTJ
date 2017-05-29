using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace FIFO
{
    public class Clan : Osoba
    {
        DateTime datum_registracije;
        int broj_bodova;
        List<Racun> historija;
        List<Termin> buducnost;

        public DateTime Datum_registracije
        {
            get
            {
                return datum_registracije;
            }

            set
            {
                datum_registracije = value;
            }
        }

        public int Broj_bodova
        {
            get
            {
                return broj_bodova;
            }

            set
            {
                broj_bodova = value;
            }
        }

        public List<Racun> Historija
        {
            get
            {
                return historija;
            }

            set
            {
                historija = value;
            }
        }

        public List<Termin> Buducnost
        {
            get
            {
                return buducnost;
            }

            set
            {
                buducnost = value;
            }
        }

        public Clan(string ime, string prezime, string email, string username, string password, BitmapImage slika, DateTime datum_registracije, int broj_bodova, List<Racun> historija, List<Termin> buducnost)
            : base(ime, prezime, email, username, password, slika)
        {
            this.Datum_registracije = datum_registracije;
            this.Broj_bodova = broj_bodova;
            this.Historija = historija;
            this.Buducnost = buducnost;
        }

        public Dictionary<string, int> statistikaSportova()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();

            foreach (Racun r in historija)
            {
                if (d.ContainsKey(r.Termin.Sport))
                {
                    d[r.Termin.Sport]++;
                }
                else
                {
                    d.Add(r.Termin.Sport, 1);
                }
            }

            return d;
        }

        public void dodajUHistoriju(Racun r)
        {
            historija.Add(r);
        }

        public void dodajNoviTermin(Termin t)
        {
            buducnost.Add(t);
        }

    }
}
