namespace Books.Domain.Entities;

public class Specifications
{
    public string Published { get; private set; }

    public string Author { get; private set; }

    public string PageCount { get; private set; }

    public List<string> Illustrator { get; private set; }

    public List<string> Genres { get; private set; }
    
    public Specifications(string published, string author, string pageCount, List<string> illustrator, List<string> genres)
    {
        Published = published;
        Author = author;
        PageCount = pageCount;
        Illustrator = illustrator;
        Genres = genres;
    }

}