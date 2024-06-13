using DVTN.Frontend.Web.Infrastructure.ViewComponents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageHero;

public class PageHeroViewComponent : BaseViewComponent
{
    public PageHeroViewComponent(IMediator mediator)
        : base(mediator)
    {
    }

    public Task<IViewComponentResult> InvokeAsync(string heroText, bool isFullSize = false) => 
        Process<PageHeroRequest, PageHeroViewModel>(
        "~/Components/ViewComponents/PageHero/Index.cshtml",
        new PageHeroRequest
        {
            HeroText = heroText,
            IsFullSize = isFullSize,
        });
}