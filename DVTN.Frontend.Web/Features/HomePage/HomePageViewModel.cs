namespace DVTN.Frontend.Web.Features.HomePage;

public class HomePageViewModel
{
    public string Title { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public string Textpanel { get; set; } = string.Empty;
    public string LargeTextPanel { get; set; } = string.Empty;

    //Added new variable for DI demo
    public string TextPanelForServiceMessage { get; set; } = string.Empty;

}