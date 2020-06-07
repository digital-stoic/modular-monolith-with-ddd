using CompanyName.MyMeetings.Modules.Venues.Domain.UnitTests.SeedWork;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Events;
using NUnit.Framework;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.UnitTests
{
    [TestFixture]
    public class VenueTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateVenue_IsSuccessful()
        {
            const string name = "Venue 1";
            const string address = "Address 1";
            const int numberOfSeats = 100;
            var venue = Venue.Create(name, address, numberOfSeats);
            var venueCreated = AssertPublishedDomainEvent<VenueCreatedDomainEvent>(venue);
            Assert.That(venueCreated.VenueId, Is.EqualTo(venue.Id));
            Assert.That(venueCreated.Name, Is.EqualTo(name));
            Assert.That(venueCreated.Address, Is.EqualTo(address));
            Assert.That(venueCreated.Capacity.NumberOfSeats, Is.EqualTo(numberOfSeats));
        }
    }
}
