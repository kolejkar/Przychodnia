using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Pacjent
    {
        public string imie;
        public string nazwisko;
        public string pesel;
        public string haslo;

        public Pacjent(string Imie, string Nazwisko, string Pesel, string Haslo)
        {
            imie = Imie;
            nazwisko = Nazwisko;
            pesel = Pesel;
            haslo = Haslo;
        }

        public Pacjent()
        {

        }
    }
}
