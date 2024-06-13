using MediatR;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageFooter;

public class PageFooterRequestHandler : IRequestHandler<PageFooterRequest, PageFooterViewModel>
{
    public async Task<PageFooterViewModel> Handle(PageFooterRequest request, CancellationToken cancellationToken)
    {
        return new PageFooterViewModel
        {
            CompanyName = "Devotion",
            AcknowledgementCopy = request.AcknowledgementCopy,
        };
    }
}