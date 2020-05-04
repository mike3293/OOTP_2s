using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ADO
{
    public class Planet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Radius { get; set; }
        public double Temperature { get; set; }
        public char IsLife { get; set; }
        public char IsAtmosphere { get; set; }

        public Planet(int iD, string name, double radius, double temperature, char isLife, char isAtmosphere)
        {
            ID = iD;
            Name = name;
            Radius = radius;
            Temperature = temperature;
            IsLife = isLife;
            IsAtmosphere = isAtmosphere;
        }
    }
}
