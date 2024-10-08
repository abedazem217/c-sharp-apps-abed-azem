﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    internal class TrainCargo:CargoVehicle
    {
        public int NumberOfContainers { get; set; }

        public override bool Load(IPortable item)
        {
            if (IsHaveRoom() && !IsOverload())
            {
                CargoItems.Add(item);
                return true;
            }
            return false;
        }

        public override bool Load(List<IPortable> items)
        {
            foreach (var item in items)
            {
                if (!Load(item))
                {
                    return false;
                }
            }
            return true;
        }

        public override bool Unload(IPortable item)
        {
            if (CargoItems.Contains(item))
            {
                CargoItems.Remove(item);
                return true;
            }
            return false;
        }

        public override bool Unload(List<IPortable> items)
        {
            foreach (var item in items)
            {
                if (!Unload(item))
                {
                    return false;
                }
            }
            return true;
        }

        public override bool IsHaveRoom()
        {
            return GetCurrentVolume() < GetMaxVolume() && GetCurrentWeight() < GetMaxWeight();
        }

        public override bool IsOverload()
        {
            return GetCurrentVolume() > GetMaxVolume() || GetCurrentWeight() > GetMaxWeight();
        }

        public override int GetMaxVolume()
        {
            return MaxVolume;
        }

        public override int GetMaxWeight()
        {
            return MaxWeight;
        }

        public override int GetCurrentVolume()
        {
            return CargoItems.Sum(item => item.GetVolume());
        }

        public override int GetCurrentWeight()
        {
            return CargoItems.Sum(item => item.GetWeight());
        }

        public override string GetPricingList()
        {
            // Implement pricing logic here
            return string.Empty;
        }
    }
}

