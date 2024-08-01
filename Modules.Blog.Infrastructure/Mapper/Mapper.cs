namespace Modules.Blog.Infrastructure.Mapper;

public static class Mapper
{
    public static BlogModel Map(this Tbl_Blog dataModel)
    {
        return new BlogModel
        {
            BlogId = dataModel.BlogId,
            BlogTitle = dataModel.BlogTitle,
            BlogAuthor = dataModel.BlogAuthor,
            BlogContent = dataModel.BlogContent
        };
    }

    public static Tbl_Blog Map(this BlogRequestModel requestModel)
    {
        return new Tbl_Blog
        {
            BlogTitle = requestModel.BlogTitle,
            BlogAuthor = requestModel.BlogAuthor,
            BlogContent = requestModel.BlogContent
        };
    }
}
