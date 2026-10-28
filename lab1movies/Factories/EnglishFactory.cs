using lab1movies.Models;

namespace lab1movies.Factories
{
    public class EnglishFactory : IPlay
    {
        public IAudio CreateAudioTrack(Movie movie)
        {
            if (!movie.LanguageFiles.TryGetValue("Английский", out var files))
            {
                throw new ArgumentException(
                    "Для фильма нет английской версии."
                );
            }

            return new AudioTrack("Английский", files.Audio);
        }

        public ISubtitles CreateSubtitle(Movie movie)
        {
            if (!movie.LanguageFiles.TryGetValue("Английский", out var files))
            {
                throw new ArgumentException(
                    "Для фильма нет английских субтитров."
                );
            }

            return new Subtitles("Английский", files.Subtitle);
        }
        
    }
}
