using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Infrastructure.ViewComponents;

public abstract class BaseViewComponent : ViewComponent
{
    private readonly IMediator _mediator;

    public BaseViewComponent(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected async Task<IViewComponentResult> Process<TRequest, TResponse>(string viewPath, TRequest request)
        where TRequest : IRequest<TResponse>
        => View(viewPath, await _mediator.Send(request));
}