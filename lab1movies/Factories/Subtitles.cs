namespace lab1movies.Factories
{
    public class Subtitles : ISubtitles
    {
        public string Language { get; }
        public string FilePath { get; }

        public Subtitles(string language, string filePath)
        {
            Language = language;
            FilePath = filePath;
        }
    }
}
