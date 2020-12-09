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

                SaveData();
            }
            else
            {
                LoadData();
                CheckDay(lekarz);
            }
        }

        public void LoadData()
        {
            Stream stream = System.IO.File.Open(lekarz.id.ToString() + ".xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            dniPracy = (List<DzienPracy>)formatter.Deserialize(stream);
            stream.Close();
        }

        public void SaveData()
        {
            Stream stream = System.IO.File.Open(lekarz.id.ToString() + ".xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, dniPracy);
            stream.Close();
        }

        public void CheckDay(Lekarz lekarz)
        {
            for (int i = 0; i < 3; i++)
            {
                if (!dniPracy.Exists(d => d.dzien.Date == DateTime.Now.AddDays(i)))
                {
                    dniPracy.Add(new DzienPracy(lekarz, DateTime.Now.AddDays(i)));
                }
            }
        }
    }
}