using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCMediator
{
    public class Runway : Command
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
