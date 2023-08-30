using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Assignment1_intern
{
    public static class XMLSerialize
    {
        public static void SerializeToFile<T>(string fileName, T data)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(fs, data);
            }
        }

        public static T DeserializeFromFile<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(fs);
                }
            }
            else
            {
                return default(T);
            }
        }
    }

}
