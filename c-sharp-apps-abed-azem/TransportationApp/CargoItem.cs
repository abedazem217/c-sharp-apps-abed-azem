using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    class CargoItem : IPortable
    {
        public int Volume { get; set; }
        public int Weight { get; set; }

        public int GetArea() => throw new NotImplementedException();
        public int[] GetSize() => throw new NotImplementedException();
        public int GetVolume() => Volume;
        public int GetWeight() => Weight;
        public void PackageItem() => throw new NotImplementedException();
        public bool IsPackaged() => throw new NotImplementedException();
        public void UnPackage() => throw new NotImplementedException();
        public bool IsFragile() => throw new NotImplementedException();
        public StorageStructure GetLocation() => throw new NotImplementedException();
        public bool IsLoaded() => throw new NotImplementedException();
    }
}
