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
        public Zaposlenik(string ime, string prezime, string email, string username, string password, BitmapImage slika) 
            : base(ime, prezime, email, username, password, slika)
        {
            
        }
    }
}
