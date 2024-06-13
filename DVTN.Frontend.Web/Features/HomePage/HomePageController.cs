using DVTN.Frontend.Web.Infrastructure.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVTN.Frontend.Web.Features.HomePage;

public class HomePageController : BaseController
{
    public HomePageController(IMediator mediator) : base(mediator)
    {
    }
    
    [Route("/")]
    public Task<ActionResult> Index()
    {
        HomePageRequest request = new HomePageRequest();
        request.ImageUrl = "brand/logo.png";
        request.Textpanel = "Text Panel";
        request.LargeTextPanel = "This is a large text panel. You can put a lot of content here to provide detailed information about your website or any other topic you want to cover.";

        return Process<HomePageRequest, HomePageViewModel>(request);
    }
}