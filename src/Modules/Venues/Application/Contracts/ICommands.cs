using MediatR;
using System;

namespace CompanyName.MyMeetings.Modules.Venues.Application.Contracts
{
    public interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
    public interface ICommand : IRequest
    {
        Guid Id { get; }
    }
}
