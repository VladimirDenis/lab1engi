using lab1movies.Models;

namespace lab1movies.Factories
{
    public class RussianFactory : IPlay
    {
        public IAudio CreateAudioTrack(Movie movie)
        {
            if (!movie.LanguageFiles.TryGetValue("Русский", out var files))
            {
                throw new ArgumentException(
                    "Для фильма нет русской версии."
                );
            }

            return new AudioTrack("Русский", files.Audio);
        }

        public ISubtitles CreateSubtitle(Movie movie)
        {
            if (!movie.LanguageFiles.TryGetValue("Русский", out var files))
            {
                throw new ArgumentException(
                    "Для фильма нет русских субтитров."
                );
            }

            return new Subtitles("Русский", files.Subtitle);
        }
    }
}
