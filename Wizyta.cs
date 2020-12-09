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
        public string PeselPacjenta;
        public bool rezerwacja = false;

        public Wizyta(TimeSpan Godzina)
        {
            godzina = Godzina;
        }
    }
}
