using SIDS.DataAccess.Models;

public class Keyword
{
    public int Id { get; set; }
    public string Word { get; set; }

    public List<Page> Pages { get; set; }
}