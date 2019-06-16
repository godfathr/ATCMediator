using System;

namespace ATCMediator
{
    public class Runway : ICommand
    {

        private IATCMediator atcMediator;

        public Runway(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
            atcMediator.SetLandingStatus(true);
        }

        public void Land()
        {
            Console.WriteLine("Landing permission granted.");
            atcMediator.SetLandingStatus(true);
        }

    }
}
