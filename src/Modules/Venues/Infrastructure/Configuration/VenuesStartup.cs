using Autofac;
using CompanyName.MyMeetings.BuildingBlocks.Application;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Emails;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;
using ILogger = Serilog.ILogger;

namespace CompanyName.MyMeetings.Modules.Venues.Infrastructure.Configuration
{
    class VenuesStartup
    {
        private static IContainer _container;

        public static void Initialize(
            string connectionString,
            IExecutionContextAccessor executionContextAccessor,
            ILogger logger,
            EmailsConfiguration emailsConfiguration,
            IEventsBus eventsBus)
        {
            var moduleLogger = logger.ForContext("Module", "Venues");
        }

        private static void ConfigureCompositionRoot(
            string connectionString,
            IExecutionContextAccessor executionContextAccessor,
            ILogger logger,
            EmailsConfiguration emailsConfiguration,
            IEventsBus eventsBus)
        {
            var containerBuilder = new ContainerBuilder();

            //containerBuilder.RegisterModule(new LogginModule)
        }
    }
}
