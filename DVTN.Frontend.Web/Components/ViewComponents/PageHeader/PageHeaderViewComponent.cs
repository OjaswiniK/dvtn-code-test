using DVTN.Frontend.Web.Infrastructure.ViewComponents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageHeader;

public class PageHeaderViewComponent : BaseViewComponent
{
    public PageHeaderViewComponent(IMediator mediator)
        : base(mediator)
    {
    }

    public Task<IViewComponentResult> InvokeAsync() => Process<PageHeaderRequest, PageHeaderViewModel>(
        "~/Components/ViewComponents/PageHeader/Index.cshtml", new ());
}