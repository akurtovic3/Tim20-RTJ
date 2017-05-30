using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class Sistem
    {
        private List<Kompleks> kompleksi;
        private List<Clan> clanovi;

        public Sistem(List<Kompleks> kompleksi, List<Clan> clanovi)
        {
            this.kompleksi = kompleksi;
            this.clanovi = clanovi;
        }

        public List<Kompleks> Kompleksi
        {
            get
            {
                return kompleksi;
            }

            set
            {
                kompleksi = value;
            }
        }

        public List<Clan> Clanovi
        {
            get
            {
                return clanovi;
            }

            set
            {
                clanovi = value;
            }
        }

        public void registrujClana(Clan c)
        {
            clanovi.Add(c);
        }

        public void obrisiClana(Clan c)
        {
            clanovi.Remove(c);
        }

        public void dodajKompleks(Kompleks k)
        {
            kompleksi.Add(k);
        }

        public void obrisiKompleks(Kompleks k)
        {
            kompleksi.Remove(k);
        }
    }
}
