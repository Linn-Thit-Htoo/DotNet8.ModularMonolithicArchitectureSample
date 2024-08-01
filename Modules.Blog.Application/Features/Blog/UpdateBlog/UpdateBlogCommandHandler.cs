namespace Modules.Blog.Application.Features.Blog.UpdateBlog;

public class UpdateBlogCommandHandler
    : IRequestHandler<UpdateBlogCommand, Result<BlogResponseModel>>
{
    private readonly IBlogService _blogService;

    public UpdateBlogCommandHandler(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public async Task<Result<BlogResponseModel>> Handle(
        UpdateBlogCommand request,
        CancellationToken cancellationToken
    )
    {
        return await _blogService.UpdateBlog(
            request.RequestModel,
            request.BlogId,
            cancellationToken
        );
    }
}
