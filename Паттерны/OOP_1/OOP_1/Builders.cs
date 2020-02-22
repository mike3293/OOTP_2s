using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class TheCreator
    {
        public ClimateZone Create(ClimateZoneBuilder builder)
        {
            builder.CreateClimateZone();
            builder.SetBear();
            builder.SetFox();

            return builder.ClimateZone;
        }
    }
    internal abstract class ClimateZoneBuilder
    {
        public ClimateZone ClimateZone { get; private set; }

        public void CreateClimateZone()
        {
            ClimateZone = new ClimateZone();
        }

        public abstract void SetBear();
        public abstract void SetFox();
    }

    internal class PolarZoneBuilder : ClimateZoneBuilder
    {
        public override void SetBear()
        {
            ClimateZone.SetBear(new PolarBear(0));
        }
        public override void SetFox()
        {
            ClimateZone.SetFox(new PolarFox());
        }

    }

    internal class OldPolarZoneBuilder : ClimateZoneBuilder
    {
        public override void SetBear()
        {
            ClimateZone.SetBear(new PolarBear(10));
        }
        public override void SetFox()
        {
            ClimateZone.SetFox(new PolarFox());
        }
    }
}
