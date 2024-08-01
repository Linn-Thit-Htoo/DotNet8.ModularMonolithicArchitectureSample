using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Features.Blog.DeleteBlog
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, Result<BlogResponseModel>>
    {
        private readonly IBlogService _blogService;

        public DeleteBlogCommandHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<Result<BlogResponseModel>> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogService.DeleteBlog(request.BlogId, cancellationToken);
        }
    }
}
