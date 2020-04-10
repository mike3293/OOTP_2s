using System;
using System.Collections.Generic;

namespace OOP_5
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
        public List<string> AdditionalRooms;

        public override string ToString()
        {
            return Address.Street + ": " + Rooms + "-комн., " + Floor + " этаж, " + Material + ", " + Meter + " кв.м" + "\r\nЦена: " + Price + " $"; ;
        }
    }
}
