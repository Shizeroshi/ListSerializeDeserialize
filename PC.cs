using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLib
{
    public class PC
    {
        public delegate string Computer(string message);
        Computer console;

        public string Mark { get; set; }
        public int SerialNumber { get; set; }

        public bool IsOn = false;
        //public string On = "Computer is turned on";
        //public string Off = "Computer is turned off";
        //public string Reb = "Rebooting...";


        public PC()
        {
            Mark = "LoL";
            SerialNumber = 1488;
        }

        public PC(string mark, int serialNumber)
        {
            Mark = mark;
            SerialNumber = serialNumber;
        }

        public void TurnOn()
        {
            IsOn = true;
            console(">Computer is turned on");
        }
        public void TurnOff()
        {
            IsOn = false;
            console(">Computer is turned off");
        }
        public void Reboot()
        {
            IsOn = false;
            console(">Computer is turned off");
            Thread.Sleep(200);
            console(">Rebooting...");
            Thread.Sleep(200);
            IsOn = true;
            console(">Computer is turned on");
        }
    }
}
