using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    internal abstract class CargoVehicle : IContainable 
    {
        public Driver Driver { get; set; }
        public int MaxWeight { get; set; }
        public int MaxVolume { get; set; }
        public bool CanTravel { get; set; }
        public bool IsOverloaded { get; set; }
        public StorageStructure NextPort { get; set; }
        public StorageStructure CurrentPort { get; set; }
        public int TravelID { get; set; }
        public List<IPortable> CargoItems { get; set; } = new List<IPortable>();
        public int ExpectedPayment { get; set; }
        public IShippingPriceCalculator PriceCalculator { get; set; }
        public int DistanceToNextPort { get; set; }

        public abstract bool Load(IPortable item);
        public abstract bool Load(List<IPortable> items);
        public abstract bool Unload(IPortable item);
        public abstract bool Unload(List<IPortable> items);
        public abstract bool IsHaveRoom();
        public abstract bool IsOverload();
        public abstract int GetMaxVolume();
        public abstract int GetMaxWeight();
        public abstract int GetCurrentVolume();
        public abstract int GetCurrentWeight();
        public abstract string GetPricingList();
    }
}
