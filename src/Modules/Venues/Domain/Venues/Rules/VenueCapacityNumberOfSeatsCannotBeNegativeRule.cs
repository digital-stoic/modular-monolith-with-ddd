using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Rules
{
    public class VenueCapacityNumberOfSeatsCannotBeNegativeRule : IBusinessRule
    {
        private readonly int _numberOfSeats;

        public VenueCapacityNumberOfSeatsCannotBeNegativeRule(int numberOfSeats)
        {
            _numberOfSeats = numberOfSeats;
        }

        public bool IsBroken() => _numberOfSeats < 0;

        public string Message => "Number of seats cannot be negative";
    }
}
