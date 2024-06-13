using MediatR;

namespace DVTN.Frontend.Web.Features.HomePage;

public class HomePageRequestHandler :
    IRequestHandler<HomePageRequest, HomePageViewModel>
{
    private readonly IMediator _mediator;

    public HomePageRequestHandler(
        IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<HomePageViewModel> Handle(HomePageRequest request, CancellationToken cancellationToken)
    {
        return new HomePageViewModel();
    }
}