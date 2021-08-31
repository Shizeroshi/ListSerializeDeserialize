using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using ClassLib;
using System.Diagnostics;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new List<PC>()
            {
                new PC() { Mark = "Lenovo", SerialNumber = 1337 },
                new PC() { Mark = "Intel", SerialNumber = 228 },
                new PC() { Mark = "Dell", SerialNumber = 322 },
                new PC() { Mark = "HP", SerialNumber = 5051 }
            };


            string Dir = @"D:\TestFolder\listSerial.txt";
            var Serializer = new JavaScriptSerializer();
            File.WriteAllText(Dir, (Serializer).Serialize(computer));
            Serializer.Deserialize<List<PC>>(File.ReadAllText(Dir));
            var OpenFile = Process.Start(Dir);
            

            

        }
    }
}
