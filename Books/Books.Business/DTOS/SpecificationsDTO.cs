namespace Books.Business.DTOS;

public class SpecificationsDTO
{
    public string Published { get; set; }

    public string Author { get; set; }

    public int PageCount { get; set; }

    public List<string> Illustrator { get; set; }

    public List<string> Genres { get; set; }
}