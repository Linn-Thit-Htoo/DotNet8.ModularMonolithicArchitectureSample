namespace Modules.Blog.Application.Features.Blog.DeleteBlog;

public class DeleteBlogCommand : IRequest<Result<BlogResponseModel>>
{
    public int BlogId { get; set; }
}
