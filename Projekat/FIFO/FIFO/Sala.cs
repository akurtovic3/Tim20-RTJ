using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class Sala
    {
        int broj_sale;
        string ime_sale;
        List<Termin> termini;

        public Sala(int broj_sale, string ime_sale, List<Termin> termini)
        {
            this.Broj_sale = broj_sale;
            this.Ime_sale = ime_sale;
            this.Termini = termini;
        }

        public int Broj_sale
        {
            get
            {
                return broj_sale;
            }

            set
            {
                broj_sale = value;
            }
        }

        public string Ime_sale
        {
            get
            {
                return ime_sale;
            }

            set
            {
                ime_sale = value;
            }
        }

        public List<Termin> Termini
        {
            get
            {
                return termini;
            }

            set
            {
                termini = value;
            }
        }

        public void dodajTermin(Termin t)
        {
            termini.Add(t);
        }
    }
}
