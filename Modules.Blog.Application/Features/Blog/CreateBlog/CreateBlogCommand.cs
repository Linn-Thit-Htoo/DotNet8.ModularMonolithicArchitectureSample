namespace Modules.Blog.Application.Features.Blog.CreateBlog;

public class CreateBlogCommand : IRequest<Result<BlogResponseModel>>
{
    public BlogRequestModel RequestModel { get; set; }
}
