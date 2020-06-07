using CompanyName.MyMeetings.BuildingBlocks.Application.Emails;
using CompanyName.MyMeetings.Modules.Venues.Application.Contracts;
using Dapper;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CompanyName.MyMeetings.Modules.Venues.IntegrationTests.SeedWork
{
    public class TestBase
    {
        protected string ConnectionString;

        protected ILogger Logger;

        protected IVenuesModules VenuesModules;

        protected IEmailSender EmailSender;

        protected ExecutionContextMock ExecutionContext;

        [SetUp]
        public async Task BeforeEachTest()
        {
            const string connectionStringEnvironmentVariable =
                "ASPNETCORE_MyMeetings_IntegrationTests_ConnectionString";
            ConnectionString = Environment.GetEnvironmentVariable(connectionStringEnvironmentVariable, EnvironmentVariableTarget.Machine);
            if (ConnectionString == null)
                throw new ApplicationException(
                    $"Define connection string to integration tests database using environment variable: {connectionStringEnvironmentVariable}"
                );

            using (var sqlConnection = new SqlConnection(ConnectionString))
                await ClearDataBase(sqlConnection);

            Logger = Substitute.For<ILogger>();
            EmailSender = Substitute.For<IEmailSender>();
            ExecutionContext = new ExecutionContextMock(Guid.NewGuid());
        }

        private static async Task ClearDataBase(IDbConnection connection)
        {
            const string sql = "DELETE FROM [venues].[Venues] ";

            await connection.ExecuteScalarAsync(sql);
        }
    }
}
