using MediatR;

namespace Infrastructure.Base.CQRS;

public interface ICommand : ICommand<Unit>
{
}
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
