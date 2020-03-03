using System;

namespace designPatternsFinal
{
    public class CarNewGPS : ICustomUser
    {

        protected int totalCash = 1_000_000;

        public void StartDriving()
        {
            Console.WriteLine("here we gooooo !");
        }

        public void EndTrip()
        {
            Console.WriteLine(" it was a GOOD trip");
        }
        public void GoFaster()
        {
            Console.WriteLine(" increasing the speed");
        }
        public void SlowDown()
        {
            Console.WriteLine("brakes is on");
        }
        public void GoLeft()
        {
            Console.WriteLine(" left ");
        }
        public void GoRight()
        {
            Console.WriteLine(" Right ");
        }

        public void GetFuelStatus()
        {
            Console.WriteLine("the tank is :"+new Random().Next(100)+"%" );
        }
        public void ShowMeTheLocation()
        {
            Console.WriteLine("im in the ("+ new Random().Next(10000)+","+ new Random().Next(10000)+")  point ");
        }

        
    }
}