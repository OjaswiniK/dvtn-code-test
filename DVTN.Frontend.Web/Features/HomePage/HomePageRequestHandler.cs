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
        //When Home Controller make async call with request class object
        //Then receive the request and create a Response object as HomePageViewModel class object and return to the view
        return new HomePageViewModel()
        {
            ImageUrl = request.ImageUrl,
            Textpanel = request.Textpanel,
            LargeTextPanel = request.LargeTextPanel,           
        };
    }
}