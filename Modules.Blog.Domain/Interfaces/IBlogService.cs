namespace Modules.Blog.Domain.Interfaces;

public interface IBlogService
{
    Task<Result<BlogListResponseModel>> GetBlogList();
    Task<Result<BlogResponseModel>> CreateBlog(BlogRequestModel requestModel);
    Task<Result<BlogResponseModel>> UpdateBlog(BlogRequestModel requestModel, int id);
    Task<Result<BlogResponseModel>> DeleteBlog(int id);
}
