using MediatR;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageHero;

public class PageHeroRequestHandler : IRequestHandler<PageHeroRequest, PageHeroViewModel>
{
    public async Task<PageHeroViewModel> Handle(PageHeroRequest request, CancellationToken cancellationToken)
    {
        return new PageHeroViewModel
        {
            HeroText = request.HeroText,
            IsFullSize = request.IsFullSize,
        };
    }
}