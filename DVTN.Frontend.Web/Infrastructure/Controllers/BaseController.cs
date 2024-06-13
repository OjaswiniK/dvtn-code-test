using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Infrastructure.Controllers;

public class BaseController : Controller
{
    protected BaseController(
        IMediator mediator)
    {
        Mediator = mediator;
    }

    protected IMediator Mediator { get; }

    protected async Task<ActionResult> Process<TRequest, TResponse>(TRequest request)
        where TRequest : IRequest<TResponse>
    {
        AddModelStateError();

        return View(await Mediator.Send(request));
    }

    protected async Task<ActionResult> ProcessActionResult<TRequest>(TRequest request)
        where TRequest : IRequest<ActionResult>
    {
        AddModelStateError();

        var actionResult = await Mediator.Send(request);
        return actionResult;
    }

    protected void AddModelStateError()
    {
        if (TempData.ContainsKey("ModelStateError"))
        {
            ModelState.AddModelError(nameof(Process), TempData["ModelStateError"]?.ToString() ?? string.Empty);
        }
    }
}