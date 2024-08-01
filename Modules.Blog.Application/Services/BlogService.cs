using Microsoft.EntityFrameworkCore;
using Modules.Blog.Domain.Interfaces;
using Modules.Blog.Infrastructure.Db;
using Modules.Blog.Infrastructure.Mapper;
using Shared.DTOs.Features;
using Shared.DTOs.Features.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Services
{
    public class BlogService : IBlogService
    {
        private readonly BlogDbContext _context;

        public BlogService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Result<BlogListResponseModel>> GetBlogList()
        {
            Result<BlogListResponseModel> responseModel;
            try
            {
                var lst = await _context.Tbl_Blogs.OrderByDescending(x => x.BlogId).ToListAsync();
                responseModel = Result<BlogListResponseModel>.SuccessResult(new BlogListResponseModel { DataLst = lst.Select(x => x.Map()).ToList() });
            }
            catch (Exception ex)
            {
                responseModel = Result<BlogListResponseModel>.FailureResult(ex);
            }

            return responseModel;
        }
    }
}
