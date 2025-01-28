using Mediator.request;

namespace Mediator;

public interface IMediator
{
    void Notify(IRequest request);
}
