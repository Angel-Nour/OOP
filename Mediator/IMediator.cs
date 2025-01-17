using Mediator.request;

namespace Mediator;

public interface IMediator
{
    void Notify(object sender, IRequest request);
}