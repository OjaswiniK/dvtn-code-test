using MediatR;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageFooter;

public class PageFooterRequest : IRequest<PageFooterViewModel>
{
    public string AcknowledgementCopy { get; set; }
}