using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Features.Blog.DeleteBlog
{
    public class DeleteBlogCommand : IRequest<Result<BlogResponseModel>>
    {
        public int BlogId { get; set; }
    }
}
