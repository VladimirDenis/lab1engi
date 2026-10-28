using static lab1movies.Factories.AudioTrack;

namespace lab1movies.Factories
{
    public class AudioTrack : IAudio
    {
        public string Language { get; }

        public string FilePath { get; }

        public AudioTrack(string language, string filePath)
        {
            Language = language;
            FilePath = filePath;
        }
        
    }
}
