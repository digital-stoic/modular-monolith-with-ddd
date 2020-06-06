using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Events
{
    public class VenueCreatedDomainEvent : DomainEventBase
    {
        public VenueCreatedDomainEvent(
            VenueId venueId,
            string name,
            string address,
            VenueCapacity capacity
        )
        {
            VenueId = venueId;
            Name = name;
            Address = address;
            Capacity = capacity;
        }

        public VenueId VenueId { get; }

        public string Name { get; }

        public string Address { get; }

        public VenueCapacity Capacity { get; }

    }
}
