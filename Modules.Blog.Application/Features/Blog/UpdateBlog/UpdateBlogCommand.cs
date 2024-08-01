namespace Modules.Blog.Application.Features.Blog.UpdateBlog;

public class UpdateBlogCommand : IRequest<Result<BlogResponseModel>>
{
    public BlogRequestModel RequestModel { get; set; }
    public int BlogId { get; set; }
}
