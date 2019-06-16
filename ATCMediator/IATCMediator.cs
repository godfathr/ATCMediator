using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCMediator
{
    public interface IATCMediator
    {
        void RegisterRunway(Runway runway);

        void RegisterFlight(Flight flight);

        bool IsLandingOk();

        void SetLandingStatus(bool status);
    }
}
