using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Wizyta
    {
        public TimeSpan godzina;
        public string choroba;

        public Pacjent pacjent;
        public bool rezerwacja = false;

        public Wizyta(TimeSpan Godzina)
        {
            godzina = Godzina;
            pacjent = new Pacjent();
        }

        public string zaleceniaLekarskie;
    }
}
