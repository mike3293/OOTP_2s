using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ADO
{
    public class Satellite
    {
        public int id { get; set; }
        public double Radius { get; set; }
        public string name { get; set; }
        public double Distance_to_Planet { get; set; }
        public string PlanetName { get; set; }

        public Satellite(int id, double radius, string name, double distance_to_Planet, string planetName)
        {
            this.id = id;
            Radius = radius;
            this.name = name;
            Distance_to_Planet = distance_to_Planet;
            PlanetName = planetName;
        }
    }
}
