using MediatR;

namespace CompanyName.MyMeetings.Modules.Venues.Application.Contracts
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}
