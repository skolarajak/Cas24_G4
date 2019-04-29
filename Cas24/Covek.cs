using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class Covek
    {
        private string Ime;
        private int DanRodjenja;
        private int MesecRodjenja;
        private int GodinaRodjenja;

        public void SetName(string ime)
        {
            this.Ime = ime;
        }

        public void SetDatumRodjenja(int dan, int mesec, int godina)
        {
            this.DanRodjenja = dan;
            this.MesecRodjenja = mesec;
            this.GodinaRodjenja = godina;
        }

        public string KaziStarost()
        {
            return "Star sam " + this.Starost().ToString() + " godina";
        }

        public string GetName()
        {
            return this.Ime;
        }

        public static string Vikni(string tekst)
        {
            return tekst.ToUpper();
        }

        private float Starost()
        {
            return DateTime.Now.Year - this.GodinaRodjenja;
        }
    }
}
