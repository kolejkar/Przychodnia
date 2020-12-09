using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class DzienPracy
    {
        public Wizyta[] wizyty;
        public Lekarz lekarz;
        public DateTime dzien;

        public DzienPracy(Lekarz lek, DateTime data)
        {
            wizyty = new Wizyta[10];
            TimeSpan godzina = new TimeSpan(8, 0, 0);
            for (int i = 0; i < 10; i++)
            {
                Wizyta wizyta = new Wizyta(godzina);
                wizyty[i] = wizyta;
                godzina = godzina.Add(new TimeSpan(0, 30, 0));
            }
            lekarz = lek;
            dzien = data;
        }
    }
}
