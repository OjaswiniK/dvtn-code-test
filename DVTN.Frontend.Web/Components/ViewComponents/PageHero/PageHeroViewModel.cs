namespace DVTN.Frontend.Web.Components.ViewComponents.PageHero;

public class PageHeroViewModel
{
    public string HeroText { get; set; }
    public bool IsFullSize { get; set; }

    public bool HasHeroText => !string.IsNullOrWhiteSpace(HeroText);
}