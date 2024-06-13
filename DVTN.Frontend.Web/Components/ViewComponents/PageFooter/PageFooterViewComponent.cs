using DVTN.Frontend.Web.Infrastructure.ViewComponents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageFooter;

public class PageFooterViewComponent : BaseViewComponent
{
    public PageFooterViewComponent(IMediator mediator)
        : base(mediator)
    {
    }

    public Task<IViewComponentResult> InvokeAsync(string acknowledgementCopy) => Process<PageFooterRequest, PageFooterViewModel>(
        "~/Components/ViewComponents/PageFooter/Index.cshtml", new PageFooterRequest
        {
            AcknowledgementCopy = acknowledgementCopy
        });
}