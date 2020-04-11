using System;
using System.Collections.Generic;

namespace OOP_6
{
    [Serializable]
    public class House
    {
        public DateTime DateOfBuilt { get; set; }
        public string Material { get; set; }
        public int Floor { get; set; }
        public decimal Rooms { get; set; }
        public int Meter { get; set; }
        public Address Address { get; set; }

        public int Price => decimal.ToInt32(Rooms) * 10000 - Floor * 54;

        public override string ToString()
        {
            return Address.City + " " + Address.Street + ": " + Rooms + "-комн., " + Floor + " этаж, " + Material + ", " + Meter + " кв.м, цена: " + Price + "$" + ", год: " + DateOfBuilt.Year;
        }
    }
}
