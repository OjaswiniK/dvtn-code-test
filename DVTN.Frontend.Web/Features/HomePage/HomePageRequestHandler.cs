using MediatR;

namespace DVTN.Frontend.Web.Features.HomePage;

public class HomePageRequestHandler :
    IRequestHandler<HomePageRequest, HomePageViewModel>
{
    private readonly IMediator _mediator;
    private readonly INewService _newService;

    public HomePageRequestHandler(
        IMediator mediator, INewService newService)
    {
        _mediator = mediator;
        _newService = newService;

    }

    public async Task<HomePageViewModel> Handle(HomePageRequest request, CancellationToken cancellationToken)
    {
        //New service is invoked here and using newServiceMessage value directly into the handler
        var newServiceMessage = _newService.GetNewServiceMessage();

        //When Home Controller make async call with request class object
        //Then receive the request and create a Response object as HomePageViewModel class object and return to the view
        return new HomePageViewModel()
        {
            ImageUrl = request.ImageUrl,
            Textpanel = request.Textpanel,
            LargeTextPanel = request.LargeTextPanel,            
            TextPanelForServiceMessage = newServiceMessage,
        };
    }
}