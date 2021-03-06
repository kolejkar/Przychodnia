﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Przychodnia.Pages
{
    public class RezerwacjaModel : PageModel
    {
        [BindProperty]
        public IndexModel IndexModel { get; set; }
        [BindProperty]
        public List<DzienPracy> dniPracy { get; set; }
        public DateTime dateTime = DateTime.Now.Date;
        [BindProperty]
        public string OpisChoroby { get; set; }
        [BindProperty]
        public int IdLekarza { get; set; }
        public Lekarz lekarz { get; set; }
        [BindProperty]
        public string Pesel { get; set; }

        public void OnGet(int idLekarza, string opisChoroby, string pesel)
        {
            OpisChoroby = opisChoroby;
            IdLekarza = idLekarza;
            Pesel = pesel;
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarz = IndexModel.lekarze.Find(l => l.id == IdLekarza);
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

        public IActionResult OnGetRegister(string dzien, int id, int idLekarza, string opisChoroby, string pesel)
        {
            DateTime data = DateTime.Parse(dzien);
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarz = IndexModel.lekarze.Find(l => l.id == idLekarza);
            LoadData();
            DzienPracy dzienPracy = dniPracy.Find(d => d.dzien.Date == data);
            dzienPracy.wizyty[id].rezerwacja = true;
            dzienPracy.wizyty[id].choroba = opisChoroby;
            dzienPracy.wizyty[id].PeselPacjenta = pesel;
            SaveData();
            return RedirectToPage("/Index");
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