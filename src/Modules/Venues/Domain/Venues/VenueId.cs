using CompanyName.MyMeetings.BuildingBlocks.Domain;
using System;

namespace CompanyName.MyMeetings.Modules.Venues.Domain
{
    public class VenueId : TypedIdValueBase
    {
        // CHECK: base()
        public VenueId(Guid value) : base(value) { }
    }
}
