using System;
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
    public class ChorobaModel : PageModel
    {
        [BindProperty]
        public RezerwacjaModel Rezerwacja{ get; set; }
        [BindProperty]
        public IndexModel IndexModel { get; set; }

        public List<Lekarz> lekarze;
        [BindProperty]
        public string opisChoroby { get; set; }
        [BindProperty]
        public int idLekarza { set; get; }
        [BindProperty]
        public string Pesel { get; set; }

        public void OnGet()
        {
            IndexModel = new IndexModel();
            IndexModel.LoadData();
            lekarze = IndexModel.lekarze;
        }

        public IActionResult OnPostSelect(int id)
        {
            if (!ModelState.IsValid)
            {
                Page();
            }
            idLekarza = id;
            return RedirectToPage("/Rezerwacja", new { idLekarza = id, opisChoroby, Pesel});
        }

       

        
    }
}