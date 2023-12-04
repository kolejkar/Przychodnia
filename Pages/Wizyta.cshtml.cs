using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Przychodnia.Pages
{
    public class WizytaModel : PageModel
    {
        [BindProperty]
        public IndexModel IndexModel { get; set; }
        [BindProperty]
        public List<DzienPracy> dniPracy { get; set; }
        [BindProperty]
        public string Imie { get; set; }
        [BindProperty]
        public string Nazwisko { get; set; }
        [BindProperty]
        public string Pesel { get; set; }
        [BindProperty]
        public DateTime dateTime { get; set; }
        [BindProperty]
        public List<Pacjent> pacjenci { get; set; }

        public Lekarz lekarz { get; set; }

        public void OnGet(string opisChoroby, string data, string dzien, int idLekarza, string pesel)
        {
            dateTime = DateTime.Parse(data);
            dateTime = dateTime.Date + TimeSpan.Parse(dzien);
            //godzina = dzien;
            Pesel = pesel;
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarz = IndexModel.lekarze.Find(l => l.id == idLekarza);
            dniPracy = XMLOperations.LoadData(lekarz);
            CheckDay(lekarz);
            PacjentLoadData();
            Pacjent pacjent = pacjenci.Find(p => p.pesel == pesel);
            Imie = pacjent.imie;
            Nazwisko = pacjent.nazwisko;
        }

        public void CheckDay(Lekarz lekarz)
        {
            bool addDay = false;
            for (int i = 0; i < 3; i++)
            {
                if (!dniPracy.Exists(d => d.dzien.Date == DateTime.Now.AddDays(i).Date))
                {
                    dniPracy.Add(new DzienPracy(lekarz, DateTime.Now.AddDays(i)));
                    addDay = true;
                }
            }
            if (addDay)
            {
                XMLOperations.SaveData(lekarz, dniPracy);
            }
        }

        public void PacjentLoadData()
        {
            Stream stream = System.IO.File.Open("pacjent.xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            pacjenci = (List<Pacjent>)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}