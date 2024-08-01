using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Features.Blog.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Result<BlogResponseModel>>
    {
        private readonly IBlogService _blogService;

        public CreateBlogCommandHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<Result<BlogResponseModel>> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogService.CreateBlog(request.RequestModel, cancellationToken);
        }
    }
}
