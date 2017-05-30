using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace FIFO
{
    public class Zaposlenik : Osoba
    {

        private int sifra_zaposlenog;
        private Kompleks radno_mjesto;
        private List<Termin> zahtjevi;

        public int Sifra_zaposlenog
        {
            get
            {
                return sifra_zaposlenog;
            }

            set
            {
                sifra_zaposlenog = value;
            }
        }

        public Kompleks Radno_mjesto
        {
            get
            {
                return radno_mjesto;
            }

            set
            {
                radno_mjesto = value;
            }
        }

        public List<Termin> Zahtjevi
        {
            get
            {
                return zahtjevi;
            }

            set
            {
                zahtjevi = value;
            }
        }

        public Zaposlenik(string ime, string prezime, string email, string username, string password, BitmapImage slika, int sifra_zaposlenog, Kompleks radno_mjesto, List<Termin> zahtjevi) 
            : base(ime, prezime, email, username, password, slika)
        {
            this.sifra_zaposlenog = sifra_zaposlenog;
            this.radno_mjesto = radno_mjesto;
            this.zahtjevi = zahtjevi;
        }


        public void dodajZahtjev(Termin t)
        {
            zahtjevi.Add(t);
        }
    }
}
