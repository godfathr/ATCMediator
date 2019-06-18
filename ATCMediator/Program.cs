using System;

namespace ATCMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IATCMediator atcMediator = new ATCMediator(); //Create a mediator
            Flight sparrow101 = new Flight(atcMediator); //Concrete colleague A
            Runway mainRunway = new Runway(atcMediator); //Concrete colleage B
            atcMediator.RegisterFlight(sparrow101); //Register colleague with mediator
            atcMediator.RegisterRunway(mainRunway); //Register colleague with mediator
            sparrow101.GetReady(); //Start communication
            mainRunway.Land(); //Send response from colleague B to colleague A
            sparrow101.Land(); //Send response from colleague B to colleage A

            Console.Read();
        }
    }
}
