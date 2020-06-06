using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Rules;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.Venues
{
    public class VenueCapacity : ValueObject
    {
        public int NumberOfSeats { get; }
        private VenueCapacity(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }
        public static VenueCapacity Create(int numberOfSeats)
        {
            CheckRule(new VenueCapacityNumberOfSeatsCannotBeNegativeRule(numberOfSeats));

            return new VenueCapacity(numberOfSeats);
        }
    }
}
