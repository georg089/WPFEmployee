using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFEmployee.Model;

namespace WPFEmployee
{
     class SerialAndDiserial
     {
     
        public static void Serialize(object _emp, string PATH)
        {
            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, _emp);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }

        }


        public static ObservableCollection<Employee> Deserialize(string PATH)
        {


            BinaryFormatter formatter = new BinaryFormatter();
            try
            {

                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    ObservableCollection<Employee> result;
                    if (fs.Length == 0)
                    {
                        return result = new ObservableCollection<Employee>();
                    }
                    else return result = formatter.Deserialize(fs) as ObservableCollection<Employee>;
                }
            }
            catch (SerializationException e)
            {

                return (null);
               
            }



        }
    }
}
