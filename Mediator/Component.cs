using Mediator.request;

namespace Mediator;

public abstract class Component
{
    protected IMediator Mediator { get; }

    protected Component(IMediator mediator)
    {
        Mediator = mediator;
    }
}