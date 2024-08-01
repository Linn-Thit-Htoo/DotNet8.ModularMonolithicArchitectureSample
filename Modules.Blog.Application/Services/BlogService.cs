namespace Modules.Blog.Application.Services;

public class BlogService : IBlogService
{
    private readonly BlogDbContext _context;

    public BlogService(BlogDbContext context)
    {
        _context = context;
    }

    public async Task<Result<BlogListResponseModel>> GetBlogList(CancellationToken cancellationToken)
    {
        Result<BlogListResponseModel> responseModel;
        try
        {
            var lst = await _context.Tbl_Blogs.OrderByDescending(x => x.BlogId).ToListAsync(cancellationToken);
            responseModel = Result<BlogListResponseModel>.SuccessResult(
                new BlogListResponseModel { DataLst = lst.Select(x => x.Map()).ToList() }
            );
        }
        catch (Exception ex)
        {
            responseModel = Result<BlogListResponseModel>.FailureResult(ex);
        }

        return responseModel;
    }

    public async Task<Result<BlogResponseModel>> CreateBlog(BlogRequestModel requestModel, CancellationToken cancellationToken)
    {
        Result<BlogResponseModel> responseModel;
        try
        {
            await _context.Tbl_Blogs.AddAsync(requestModel.Map());
            await _context.SaveChangesAsync(cancellationToken);

            responseModel = Result<BlogResponseModel>.SaveSuccessResult();
        }
        catch (Exception ex)
        {
            responseModel = Result<BlogResponseModel>.FailureResult(ex);
        }

        return responseModel;
    }

    public async Task<Result<BlogResponseModel>> UpdateBlog(BlogRequestModel requestModel, int id, CancellationToken cancellationToken)
    {
        Result<BlogResponseModel> responseModel;
        try
        {
            var item = await _context.Tbl_Blogs.FindAsync(id);
            if (item is null)
            {
                responseModel = Result<BlogResponseModel>.NotFoundResult();
                goto result;
            }

            item.BlogTitle = requestModel.BlogTitle;
            item.BlogAuthor = requestModel.BlogAuthor;
            item.BlogContent = requestModel.BlogContent;

            _context.Tbl_Blogs.Update(item);
            await _context.SaveChangesAsync(cancellationToken);

            responseModel = Result<BlogResponseModel>.UpdateSuccessResult();
        }
        catch (Exception ex)
        {
            responseModel = Result<BlogResponseModel>.FailureResult(ex);
        }

        result:
        return responseModel;
    }

    public async Task<Result<BlogResponseModel>> DeleteBlog(int id, CancellationToken cancellationToken)
    {
        Result<BlogResponseModel> responseModel;
        try
        {
            var item = await _context.Tbl_Blogs.FindAsync(id);
            if (item is null)
            {
                responseModel = Result<BlogResponseModel>.NotFoundResult();
                goto result;
            }

            _context.Tbl_Blogs.Remove(item);
            await _context.SaveChangesAsync(cancellationToken);

            responseModel = Result<BlogResponseModel>.DeleteSuccessResult();
        }
        catch (Exception ex)
        {
            responseModel = Result<BlogResponseModel>.FailureResult(ex);
        }

        result:
        return responseModel;
    }
}
