using CompanyName.MyMeetings.Modules.Venues.Domain.UnitTests.SeedWork;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues;
using CompanyName.MyMeetings.Modules.Venues.Domain.Venues.Rules;
using NUnit.Framework;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.UnitTests
{
    [TestFixture]
    class VenueCapacityTests : TestBase
    {
        [Test]
        public void CreateVenueCapacity_WhenNumberOfSeatsIsPositive_IsScuccessful()
        {
            var venueCapacity = VenueCapacity.Create(42);

            Assert.That(venueCapacity.NumberOfSeats, Is.EqualTo(42));
        }

        [Test]
        public void CreateVenueCapacity_WhenNumberOfSeatsIsPositive_BreaksVenueCapacityNumberOfSeatsCannotBeNegativeRule()
        {
            AssertBrokenRule<VenueCapacityNumberOfSeatsCannotBeNegativeRule>(() =>
                VenueCapacity.Create(-42)
            );
        }
    }
}
