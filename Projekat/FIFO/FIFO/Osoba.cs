using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace FIFO
{
    public abstract class Osoba
    {
        private string ime;
        private string prezime;
        private string email;
        private string username;
        private string password;
        private BitmapImage slika;

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public BitmapImage Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }

        public Osoba(string ime, string prezime, string email, string username, string password, BitmapImage slika)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Slika = slika;
        }
    }
}
