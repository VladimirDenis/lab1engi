using lab1movies.Factories;

namespace lab1movies.Models
{
    public class MoviePackage
    {
        public Movie Movie { get; set; } = new();

        public IAudio AudioTrack { get; set; } = null!;

        public ISubtitles Subtitle { get; set; } = null!;
    }

}
