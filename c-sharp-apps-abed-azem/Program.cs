using c_sharp_apps_abed_azem.common.system.shared;
using c_sharp_apps_abed_azem.TransportationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MonitorTransportation.RunAllTests();
            Console.ReadKey();

        }
    }
}
