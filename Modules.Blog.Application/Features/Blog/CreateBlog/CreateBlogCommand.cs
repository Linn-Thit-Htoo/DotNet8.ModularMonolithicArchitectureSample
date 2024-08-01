using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Features.Blog.CreateBlog
{
    public class CreateBlogCommand : IRequest<Result<BlogResponseModel>>
    {
        public BlogRequestModel RequestModel { get; set; }
    }
}
