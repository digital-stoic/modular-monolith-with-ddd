using CompanyName.MyMeetings.BuildingBlocks.Application;
using System;

namespace CompanyName.MyMeetings.Modules.Venues.IntegrationTests.SeedWork
{
    public class ExecutionContextMock : IExecutionContextAccessor
    {
        public Guid UserId { get; }

        public Guid CorrelationId { get; }

        public bool IsAvailable { get; }

        public ExecutionContextMock(Guid userId)
        {
            UserId = userId;
        }
    }
}
