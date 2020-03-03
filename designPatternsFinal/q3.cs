using System;

namespace designPatternsFinal
{
    class q3
    {
        static void Main(string[] args)
        {
            CarNewGPS car = new CarNewGPS();
            GetProxy(new CarProxy());

        }
        static void GetProxy(ICustomUser proxy)
        {
            proxy.GetFuelStatus();
            proxy.ShowMeTheLocation();
        }
    }
}
