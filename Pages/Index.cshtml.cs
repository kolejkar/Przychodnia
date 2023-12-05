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
    public class IndexModel : PageModel
    {
        public List<Lekarz> lekarze;

        public void OnGet()
        {
            if (!System.IO.File.Exists("lekarze.xml"))
            {
                lekarze = new List<Lekarz>();
                lekarze.Add(new Lekarz(1, "Jan", "Kowalski","1234"));
                lekarze.Add(new Lekarz(2, "Ania", "Rydz","1234"));

                SaveData();
            }
        }

        public void SaveData()
        {
            Stream stream = System.IO.File.Open("lekarze.xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, lekarze);
            stream.Close();
        }

        public void LoadData()
        {
            Stream stream = System.IO.File.Open("lekarze.xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            lekarze = (List<Lekarz>)formatter.Deserialize(stream);
            stream.Close();
        }

        public static string Pesel;
    }
}
