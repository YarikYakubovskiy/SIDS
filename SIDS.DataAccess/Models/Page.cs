namespace SIDS.DataAccess.Models;

public class Page
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Url { get; set; }

    public List<Keyword> Keywords { get; set; }

    public string Description { get; set; }
}