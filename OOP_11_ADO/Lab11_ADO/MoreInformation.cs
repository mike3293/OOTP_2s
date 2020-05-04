using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ADO
{
    public class MoreInformation
    {
        public int id;
        public string PlanetName;
        public string Descriprion;

        public MoreInformation(int id, string descriprion, string planetName)
        {
            this.id = id;
            PlanetName = planetName;
            Descriprion = descriprion;
        }
    }
}
