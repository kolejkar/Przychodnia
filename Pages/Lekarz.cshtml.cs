using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Przychodnia.Pages
{
    public class LekarzModel : PageModel
    {
        [BindProperty]
        public IndexModel IndexModel { get; set; }
        [BindProperty]
        public List<DzienPracy> dniPracy { get; set; }
        public DateTime dateTime = DateTime.Now.Date;
        public Lekarz lekarz { get; set; }

        public void OnGet(int idLekarza)
        {
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarz = IndexModel.lekarze.Find(l => l.id == idLekarza);
            if (!System.IO.File.Exists(lekarz.id.ToString() + ".xml"))
            {
                dniPracy = new List<DzienPracy>();
                dniPracy.Add(new DzienPracy(lekarz, DateTime.Now));
                dniPracy.Add(new DzienPracy(lekarz, DateTime.Now.AddDays(1)));
                dniPracy.Add(new DzienPracy(lekarz, DateTime.Now.AddDays(2)));

                XMLOperations.SaveData(lekarz, dniPracy);
            }
            else
            {
                dniPracy = XMLOperations.LoadData(lekarz);
                CheckDay(lekarz);
            }
        }

        public IActionResult OnGetRegister(string dzien, string data, int idLekarza, string opisChoroby, string pesel)
        {
            //DateTime data1 = DateTime.Parse(data);
            //TimeSpan dzien1 = TimeSpan.Parse(dzien);
            return RedirectToPage("/Wizyta", new {opisChoroby, data, dzien, idLekarza, pesel });
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
    }
}