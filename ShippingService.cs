using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class ShippingService
    {
        private double PricePerMass;
        public ShippingService(double mass_unit) { this.PricePerMass = mass_unit; }
        public double Price(IShipable item)
        {
            return PricePerMass * item.Weight;
        }
        public override string ToString()
        {
            return "Shipping price is:";
        }
    }
}
