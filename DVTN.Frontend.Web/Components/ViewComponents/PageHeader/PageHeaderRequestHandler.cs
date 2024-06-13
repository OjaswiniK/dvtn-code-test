using MediatR;

namespace DVTN.Frontend.Web.Components.ViewComponents.PageHeader;

public class PageHeaderRequestHandler : IRequestHandler<PageHeaderRequest, PageHeaderViewModel>
{
    public async Task<PageHeaderViewModel> Handle(PageHeaderRequest request, CancellationToken cancellationToken)
    {
        return new PageHeaderViewModel();
    }
}