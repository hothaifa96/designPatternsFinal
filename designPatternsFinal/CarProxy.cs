namespace designPatternsFinal
{
    internal class CarProxy:ICustomUser
    {
        public CarProxy()
        {
        }

        public void GetFuelStatus()
        {
            ICustomUser car = new CarNewGPS();
            car.GetFuelStatus();
        }

        public void ShowMeTheLocation()
        {
            ICustomUser car = new CarNewGPS();
            car.ShowMeTheLocation();
        }
    }
}