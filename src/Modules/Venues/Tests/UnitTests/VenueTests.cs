using CompanyName.MyMeetings.Modules.Venues.Domain.Venues;
using NUnit.Framework;

namespace CompanyName.MyMeetings.Modules.Venues.Domain.UnitTests
{
    public class VenueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var venue = Venue.RegisterNewVenue();
            Assert.Pass();
        }
    }
}
