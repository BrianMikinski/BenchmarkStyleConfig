public class ClassBlog
{
    public ClassBlog()
    {
        Id = 1;
        Title = DataConstants.Title;
        Content = DataConstants.Content;
        Category = BlogCategory.Automotive;
    }

    public int Id { get; init; }

    public string Title { get; init; }

    public string Content { get; init; }

    public BlogCategory Category { get; init; }
}
