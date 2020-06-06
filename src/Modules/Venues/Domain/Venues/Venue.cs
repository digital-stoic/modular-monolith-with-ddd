using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Events;
using System;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.Venues
{
    public class Venue : Entity, IAggregateRoot
    {
        public VenueId Id { get; private set; }

        private string _name;

        // TODO: Define an Address type?
        private string _address;

        private VenueCapacity _capacity;

        private Venue() { }

        private Venue(
            string name,
            string address,
            VenueCapacity capacity)
        {
            // TODO: Check name is unique

            this.Id = new VenueId(Guid.NewGuid());
            _name = name;
            _address = address;
            _capacity = capacity;

            this.AddDomainEvent(new VenueCreatedDomainEvent(this.Id, name, address, capacity));
        }

        public static Venue Create(
            string name,
            string address,
            int numberOfSeats)
        {

            return new Venue(name, address, VenueCapacity.Create(numberOfSeats));
        }
    }
}
