using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Przychodnia
{
    public class PacjentIO
    {
        public static void SaveData(List<Pacjent> pacjenci)
        {

            Stream stream = System.IO.File.Open("pacjent.xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, pacjenci);
            stream.Close();
        }

        public static List<Pacjent> LoadData()
        {
            List<Pacjent> pacjenci;
            Stream stream = System.IO.File.Open("pacjent.xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            pacjenci = (List<Pacjent>)formatter.Deserialize(stream);
            stream.Close();
            return pacjenci;
        }
    }
}
