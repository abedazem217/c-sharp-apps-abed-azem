using c_sharp_apps_abed_azem.Bankapp;
using c_sharp_apps_abed_azem.Draftapp;
using c_sharp_apps_abed_azem.SportApp;
using c_sharp_apps_abed_azem.TransportationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.common.system.shared
{
    internal class ProcessManeger
    {
        public static void RunMainProcess()
        {
            int choice;

            Console.WriteLine("choose one option");
            Console.WriteLine(" 1- Bank App");
            Console.WriteLine(" 2- sport app");
            Console.WriteLine(" 3- transportation app");
            Console.WriteLine(" 4- Draft app");
            Console.WriteLine(" 0- exit");

            choice = int.Parse(Console.ReadLine());

            if ( choice < 0 || choice > 4 )
                Console.WriteLine("error");
            if (choice == 1)
                BankAppMain.MAinEntry();
            if (choice == 2)
                SportAppMain.MAinEntry();   
            if (choice == 3)
                TransportationAppMain.MAinEntry();
            if (choice == 4)
                DraftAppMain.MAinEntry();
            if(choice == 0)
                Console.WriteLine("Exiting....");


        }
    }
}
