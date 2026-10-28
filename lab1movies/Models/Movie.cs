namespace lab1movies.Models;

public class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public int Year { get; set; }

    public string Description { get; set; } = "";

    public string PosterPath { get; set; } = "";

    public List<string> AvailableLanguages { get; set; } = new();

    public Dictionary<string, MovieLanguageFiles> LanguageFiles { get; set; } = new();
}
