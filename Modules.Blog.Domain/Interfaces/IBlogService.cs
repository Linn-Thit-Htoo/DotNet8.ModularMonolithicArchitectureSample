namespace Modules.Blog.Domain.Interfaces;

public interface IBlogService
{
    Task<Result<BlogListResponseModel>> GetBlogList(CancellationToken cancellationToken);
    Task<Result<BlogResponseModel>> CreateBlog(BlogRequestModel requestModel, CancellationToken cancellationToken);
    Task<Result<BlogResponseModel>> UpdateBlog(BlogRequestModel requestModel, int id, CancellationToken cancellationToken);
    Task<Result<BlogResponseModel>> DeleteBlog(int id, CancellationToken cancellationToken);
}
