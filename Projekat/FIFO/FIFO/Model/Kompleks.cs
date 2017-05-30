using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class Kompleks
    {
        private string lokacija;
        private List<Sala> sale;
        private List<Zaposlenik> zaposleni;
        private string ime_kompleksa;
        private List<Termin> termini;

        public string Lokacija
        {
            get
            {
                return lokacija;
            }

            set
            {
                lokacija = value;
            }
        }

        public List<Sala> Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale = value;
            }
        }

        public List<Zaposlenik> Zaposleni
        {
            get
            {
                return zaposleni;
            }

            set
            {
                zaposleni = value;
            }
        }

        public string Ime_kompleksa
        {
            get
            {
                return ime_kompleksa;
            }

            set
            {
                ime_kompleksa = value;
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

        public Kompleks(string lokacija, List<Sala> sale, List<Zaposlenik> zaposleni, string ime_kompleksa, List<Termin> termini)
        {
            this.Lokacija = lokacija;
            this.Sale = sale;
            this.Zaposleni = zaposleni;
            this.Ime_kompleksa = ime_kompleksa;
            this.Termini = termini;
        }


        public void dodajSalu(Sala s)
        {
            sale.Add(s);
        }

        public void registrujUposlenika(Zaposlenik z)
        {
            zaposleni.Add(z);
        }

        public void zakaziTermin(Termin t)
        {
            termini.Add(t);
        }

        public void otkaziTermin(Termin t)
        {
            termini.Remove(t);
        }

        public void obrisiSalu(Sala s)
        {
            sale.Remove(s);
        }

        public void otpustiUposlenika(Zaposlenik z)
        {
            zaposleni.Remove(z);
        }
    }
}
