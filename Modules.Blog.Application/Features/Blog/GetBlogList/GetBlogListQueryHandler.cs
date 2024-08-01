namespace Modules.Blog.Application.Features.Blog.GetBlogList;

public class GetBlogListQueryHandler
    : IRequestHandler<GetBlogListQuery, Result<BlogListResponseModel>>
{
    private readonly IBlogService _blogService;

    public GetBlogListQueryHandler(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public async Task<Result<BlogListResponseModel>> Handle(
        GetBlogListQuery request,
        CancellationToken cancellationToken
    )
    {
        return await _blogService.GetBlogList(cancellationToken);
    }
}
