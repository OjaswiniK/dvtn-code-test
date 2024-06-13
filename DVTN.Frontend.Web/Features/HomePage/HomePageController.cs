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
    public Task<ActionResult> Index() => Process<HomePageRequest, HomePageViewModel>(new ());
}