namespace OOP_1
{
    internal class ClimateZone
    {
        private Bear bear;
        private Fox fox;

        public ClimateZone(ClimateZoneFactory factory)
        {
            bear = factory.CreateBear();
            fox = factory.CreateFox();
        }

        public void HearBear()
        {
            bear.Growl();
        }

        public void SeeFox()
        {
            fox.Run();
        }


        public ClimateZone()    // for builder
        {
            bear = new PolarBear();
            fox = new PolarFox();
        }

        public void SetBear(Bear bear)
        {
            this.bear = bear;
        }

        public void SetFox(Fox fox)
        {
            this.fox = fox;
        }
    }
}
