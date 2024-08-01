using Shared.DTOs.Features;
using Shared.DTOs.Features.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Domain.Interfaces
{
    public interface IBlogService
    {
        Task<Result<BlogListResponseModel>> GetBlogList();
    }
}
