using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Lekarz
    {
        public string imie;
        public string nazwisko;
        public int id;
        public string haslo;

        public Lekarz(int Id, string Imie, string Nazwisko)
        {
            imie = Imie;
            nazwisko = Nazwisko;
            id = Id;
        }

        public Lekarz(int Id, string Imie, string Nazwisko, string Haslo)
        {
            imie = Imie;
            nazwisko = Nazwisko;
            id = Id;
            haslo = Haslo;
        }
    }
}
