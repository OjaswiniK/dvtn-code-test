using MediatR;

namespace DVTN.Frontend.Web.Features.HomePage;

public class HomePageRequest : IRequest<HomePageViewModel>
{
    public string ImageUrl { get; set; }
    public string Textpanel { get; set; }

    public string LargeTextPanel { get; set; }
}