using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class Racun
    {
        private int broj_racuna;
        private bool kupon;
        private Zaposlenik zaposlenik;
        private int broj_odigranih;
        Termin termin;

        public int Broj_racuna
        {
            get
            {
                return broj_racuna;
            }

            set
            {
                broj_racuna = value;
            }
        }

        public bool Kupon
        {
            get
            {
                return kupon;
            }

            set
            {
                kupon = value;
            }
        }

        public Zaposlenik Zaposlenik
        {
            get
            {
                return zaposlenik;
            }

            set
            {
                zaposlenik = value;
            }
        }

        public int Broj_odigranih
        {
            get
            {
                return broj_odigranih;
            }

            set
            {
                broj_odigranih = value;
            }
        }

        public Termin Termin
        {
            get
            {
                return termin;
            }

            set
            {
                termin = value;
            }
        }

        public Racun(int broj_racuna, bool kupon, Zaposlenik zaposlenik, int broj_odigranih, Termin termin)
        {
            this.Broj_racuna = broj_racuna;
            this.Kupon = kupon;
            this.Zaposlenik = zaposlenik;
            this.Broj_odigranih = broj_odigranih;
            this.Termin = termin;
        }
    }
}
