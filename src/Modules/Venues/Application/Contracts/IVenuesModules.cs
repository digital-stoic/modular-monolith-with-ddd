using System.Threading.Tasks;

namespace CompanyName.MyMeetings.Modules.Venues.Application.Contracts
{
    public interface IVenuesModules
    {
        Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command);

        Task ExecuteCommandAsync(ICommand command);

        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);

    }
}
