using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Features.Blog.UpdateBlog
{
    public class UpdateBlogCommand : IRequest<Result<BlogResponseModel>>
    {
        public BlogRequestModel RequestModel { get; set; }
        public int BlogId { get; set; }
    }
}
