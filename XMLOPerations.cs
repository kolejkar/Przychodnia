using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Przychodnia
{
    public class XMLOperations
    {
        static public List<DzienPracy> LoadData(Lekarz lekarz)
        {
            List<DzienPracy> dniPracy;

            Stream stream = System.IO.File.Open(lekarz.id.ToString() + ".xml", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            dniPracy = (List<DzienPracy>)formatter.Deserialize(stream);
            stream.Close();

            return dniPracy;
        }

        static public void SaveData(Lekarz lekarz, List<DzienPracy> dniPracy)
        {
            
            Stream stream = System.IO.File.Open(lekarz.id.ToString() + ".xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, dniPracy);
            stream.Close();
        }
    }
}
