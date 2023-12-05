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
    public class LoginModel : PageModel
    {
        [BindProperty]
        public IndexModel IndexModel { get; set; }

        public List<Lekarz> lekarze;
        public List<Pacjent> pacjenci;

        [BindProperty]
        public string Pesel { get; set; }
        [BindProperty]
        public string Haslo { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (IndexModel.Pesel == null)
            {
                try
                {
                    int id = int.Parse(Pesel);
                    IndexModel = new IndexModel();
                    IndexModel.LoadData();
                    lekarze = IndexModel.lekarze;
                    if (ModelState.IsValid == false)
                    {
                        return Page();
                    }
                    Lekarz lek = lekarze.First(l => l.id == id && l.haslo == Haslo);
                    if (lek == null)
                    {
                        return Page();
                    }
                    else
                    {
                        IndexModel.Pesel = Pesel;
                        return RedirectToPage("/Lekarz", new { idLekarza = id });
                    }
                }
                catch (FormatException)
                {
                    if (System.IO.File.Exists("pacjent.xml"))
                    {
                        pacjenci = PacjentIO.LoadData();
                    }
                    if (pacjenci != null)
                    {
                        Pacjent pacjent = pacjenci.Find(p => p.pesel == Pesel);
                        if (pacjent != null)
                        {
                            IndexModel.Pesel = Pesel;
                            return RedirectToPage("/Historia");
                        }
                    }
                }
            }
            return RedirectToPage("/Index");
        }
    }
}