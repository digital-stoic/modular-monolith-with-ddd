using CompanyName.MyMeetings.BuildingBlocks.Domain;


namespace CompanyName.MyMeetings.Modules.Venues.Domain.Venues
{
    public class Venue : Entity, IAggregateRoot
    {
        private Venue() { }
        public static Venue RegisterNewVenue()
        {
            return new Venue();
        }
    }
}
