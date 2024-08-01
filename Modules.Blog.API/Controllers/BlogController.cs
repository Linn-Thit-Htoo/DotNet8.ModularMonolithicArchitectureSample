namespace Modules.Blog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet]
    public async Task<IActionResult> GetBlogs()
    {
        var result = await _blogService.GetBlogList();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog([FromBody] BlogRequestModel requestModel)
    {
        var result = await _blogService.CreateBlog(requestModel);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBlog([FromBody] BlogRequestModel requestModel, int id)
    {
        var result = await _blogService.UpdateBlog(requestModel, id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBlog(int id)
    {
        var result = await _blogService.DeleteBlog(id);
        return Ok(result);
    }
}
