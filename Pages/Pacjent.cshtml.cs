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
    public class PacjentModel : PageModel
    {
        [BindProperty]
        public IndexModel IndexModel { get; set; }

        public List<Pacjent> pacjenci;

        [BindProperty]
        public string Imie { get; set; }
        [BindProperty]
        public string Nazwisko { get; set; }
        [BindProperty]
        public string Haslo { get; set; }
        [BindProperty]
        public string Pesel { get; set; }
        [BindProperty]
        public string OpisChoroby { get; set; }
        [BindProperty]
        public int IdLekarza { get; set; }

        public void OnGet(int idLekarza, string opisChoroby, string pesel)
        {
            idLekarza = IdLekarza;
            opisChoroby = OpisChoroby;
            pesel = Pesel;
            if (System.IO.File.Exists("pacjent.xml"))
            {
                LoadData();
            }
            if (pacjenci != null)
            {
                Pacjent pacjent = pacjenci.Find(p => p.pesel == pesel);
                if (pacjent != null)
                {
                    RedirectToPage("/Rezerwacja", new { IdLekarza, OpisChoroby, Pesel });
                }
            }
        }

        public IActionResult OnPost()
        {
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            //lekarze = IndexModel.lekarze;
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            if (System.IO.File.Exists("pacjent.xml"))
            {
                LoadData();
            }
            else
            {
                pacjenci = new List<Pacjent>();
            }
            Pacjent pacjent = new Pacjent();
            pacjent.imie = Imie;
            pacjent.nazwisko = Nazwisko;
            pacjent.haslo = Haslo;
            pacjent.pesel = Pesel;
            pacjenci.Add(pacjent);
            SaveData();
            return RedirectToPage("/Rezerwacja", new { IdLekarza, OpisChoroby, pacjent.pesel });
        }

        public void SaveData()
        {

            Stream stream = System.IO.File.Open("pacjent.xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, pacjenci);
            stream.Close();
        }

        public void LoadData()
        {
            Stream stream = System.IO.File.Open("pacjent.xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            pacjenci = (List<Pacjent>)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}