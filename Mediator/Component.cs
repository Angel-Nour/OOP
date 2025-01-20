using Mediator.request;

namespace Mediator;

public abstract class Component
{
    public IMediator Mediator { get; private set; }
    public void SetMediator(IMediator mediator)
    {
        Mediator = mediator;
    }

    protected void NotifyMediator(IRequest request)
    {
        Mediator?.Notify(this, request);
    }
}