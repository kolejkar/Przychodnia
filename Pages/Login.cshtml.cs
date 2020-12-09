using System;
using System.Collections.Generic;
using System.Linq;
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

        [BindProperty]
        public string Imie { get; set; }
        [BindProperty]
        public string Nazwisko { get; set; }
        [BindProperty]
        public string Haslo { get; set; }
        [BindProperty]
        public int idLekarza { set; get; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarze = IndexModel.lekarze;
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            Lekarz lek = lekarze.First(l => l.imie == Imie && l.nazwisko == Nazwisko && l.haslo == Haslo);
            if (lek == null)
            {
                return Page();
            }
            else
            {
                idLekarza = lek.id;
                return RedirectToPage("/Lekarz", new { idLekarza = lek.id });
            }
        }
    }
}