using lab1movies.Models;

namespace lab1movies.Factories
{
    public interface IPlay
    {
        IAudio CreateAudioTrack(Movie movie);

        ISubtitles CreateSubtitle(Movie movie);
    }
}
