using MediatR;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageHero;

public class PageHeroRequest : IRequest<PageHeroViewModel>
{
    public string HeroText { get; set; }
    public bool IsFullSize { get; set; }
}