using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class Termin
    {
        DateTime datum;
        string vrijeme;
        Sala sala;
        string sport;
        double cijena;

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public string Vrijeme
        {
            get
            {
                return vrijeme;
            }

            set
            {
                vrijeme = value;
            }
        }

        public Sala Sala
        {
            get
            {
                return sala;
            }

            set
            {
                sala = value;
            }
        }

        public string Sport
        {
            get
            {
                return sport;
            }

            set
            {
                sport = value;
            }
        }

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public Termin(DateTime datum, string vrijeme, Sala sala, string sport, double cijena)
        {
            this.Datum = datum;
            this.Vrijeme = vrijeme;
            this.Sala = sala;
            this.Sport = sport;
            this.Cijena = cijena;
        }
    }
}
