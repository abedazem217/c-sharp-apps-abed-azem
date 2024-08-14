using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    public class TransportationAppMain
    {
        public static void MainEntry()
        {
            MonitorTransportation.RunAllTests();
            Console.ReadKey();
        }
    }
}