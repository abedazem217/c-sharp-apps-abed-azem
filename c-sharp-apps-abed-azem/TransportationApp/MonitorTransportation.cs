using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    class MonitorTransportation
    {
        public static void RunAllTests()
        {
            Console.WriteLine("Running All Tests...");

            // Test 1: Loading items into TrainCargo
            IPortable item1 = new CargoItem { Volume = 150, Weight = 300 };
            IPortable item2 = new CargoItem { Volume = 250, Weight = 400 };
            IPortable item3 = new CargoItem { Volume = 100, Weight = 150 };

            TrainCargo trainCargo = new TrainCargo { MaxVolume = 1000, MaxWeight = 2000 };
            bool trainLoadSuccess = trainCargo.Load(new List<IPortable> { item1, item2, item3 });
            Console.WriteLine($"Test 1 - TrainCargo Load: {(trainLoadSuccess ? "Passed" : "Failed")}");

            // Test 2: Loading items into ShipCargo
            ShipCargo shipCargo = new ShipCargo { MaxVolume = 5000, MaxWeight = 10000 };
            bool shipLoadSuccess = shipCargo.Load(new List<IPortable> { item1, item2, item3 });
            Console.WriteLine($"Test 2 - ShipCargo Load: {(shipLoadSuccess ? "Passed" : "Failed")}");

            // Test 3: Unloading items from TrainCargo
            bool trainUnloadSuccess = trainCargo.Unload(new List<IPortable> { item1, item2 });
            Console.WriteLine($"Test 3 - TrainCargo Unload: {(trainUnloadSuccess ? "Passed" : "Failed")}");

            // Test 4: Unloading items from ShipCargo
            bool shipUnloadSuccess = shipCargo.Unload(new List<IPortable> { item1, item2 });
            Console.WriteLine($"Test 4 - ShipCargo Unload: {(shipUnloadSuccess ? "Passed" : "Failed")}");

            // Test 5: Check for overloading TrainCargo
            trainCargo.Load(item3);
            bool isTrainOverloaded = trainCargo.IsOverload();
            Console.WriteLine($"Test 5 - TrainCargo Overload: {(isTrainOverloaded ? "Failed" : "Passed")}");

            // Test 6: Check for overloading ShipCargo
            shipCargo.Load(item3);
            bool isShipOverloaded = shipCargo.IsOverload();
            Console.WriteLine($"Test 6 - ShipCargo Overload: {(isShipOverloaded ? "Failed" : "Passed")}");

            // Test 7: Calculate total load weight in TrainCargo
            int trainTotalWeight = trainCargo.GetCurrentWeight();
            Console.WriteLine($"Test 7 - TrainCargo Total Weight: {trainTotalWeight}");

            // Test 8: Calculate total load weight in ShipCargo
            int shipTotalWeight = shipCargo.GetCurrentWeight();
            Console.WriteLine($"Test 8 - ShipCargo Total Weight: {shipTotalWeight}");

            // Test 9: Calculate total load volume in TrainCargo
            int trainTotalVolume = trainCargo.GetCurrentVolume();
            Console.WriteLine($"Test 9 - TrainCargo Total Volume: {trainTotalVolume}");

            // Test 10: Calculate total load volume in ShipCargo
            int shipTotalVolume = shipCargo.GetCurrentVolume();
            Console.WriteLine($"Test 10 - ShipCargo Total Volume: {shipTotalVolume}");

            Console.WriteLine("All tests completed.");
        }
    }

   
}