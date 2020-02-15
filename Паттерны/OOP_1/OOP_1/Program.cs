using System;

namespace OOP_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClimateZoneFactory factory = new PolarFactory();
            ClimateZone zone = new ClimateZone(factory);
            zone.SeeFox();

            Earth earth = Earth.GetInstance();
            earth.EarthShake();

            TheCreator creator = new TheCreator();
            ClimateZoneBuilder builder = new MildZoneBuilder();
            ClimateZone zoneFromBuilder = creator.Create(builder);
            zoneFromBuilder.HearBear();

            Console.ReadKey();
        }
    }
}
