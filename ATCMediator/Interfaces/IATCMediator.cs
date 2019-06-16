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
