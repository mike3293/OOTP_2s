namespace OOP_1
{
    internal interface ClimateZoneFactory
    {
        Bear CreateBear();
        Fox CreateFox();
    }

    internal class PolarFactory : ClimateZoneFactory
    {
        public Bear CreateBear()
        {
            return new PolarBear();
        }

        public Fox CreateFox()
        {
            return new PolarFox();
        }
    }

    internal class MildFactory : ClimateZoneFactory
    {
        public Bear CreateBear()
        {
            return new BrownBear();
        }

        public Fox CreateFox()
        {
            return new CommonFox();
        }
    }
}
