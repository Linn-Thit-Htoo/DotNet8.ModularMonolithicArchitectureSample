﻿using MediatR;
using Modules.Blog.Application.Features.Blog.CreateBlog;
using Modules.Blog.Application.Features.Blog.DeleteBlog;
using Modules.Blog.Application.Features.Blog.GetBlogList;
using Modules.Blog.Application.Features.Blog.UpdateBlog;

namespace Modules.Blog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;
    private readonly IMediator _mediator;

    public BlogController(IBlogService blogService, IMediator mediator)
    {
        _blogService = blogService;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetBlogs()
    {
        var query = new GetBlogListQuery();
        var result = await _mediator.Send(query);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog([FromBody] BlogRequestModel requestModel)
    {
        var command = new CreateBlogCommand() { RequestModel = requestModel };
        var result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBlog([FromBody] BlogRequestModel requestModel, int id)
    {
        var command = new UpdateBlogCommand() { BlogId = id, RequestModel = requestModel };
        var result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBlog(int id)
    {
        var command = new DeleteBlogCommand() { BlogId = id };
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}
