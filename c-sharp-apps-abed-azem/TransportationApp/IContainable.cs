using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    internal interface IContainable
    {
        bool Load(IPortable item);
        bool Load(List<IPortable> items);
        bool Unload(IPortable item);
        bool Unload(List<IPortable> items);
        bool IsHaveRoom();
        bool IsOverload();
        int GetMaxVolume();
        int GetMaxWeight();
        int GetCurrentVolume();
        int GetCurrentWeight();
        string GetPricingList();
    }
}
