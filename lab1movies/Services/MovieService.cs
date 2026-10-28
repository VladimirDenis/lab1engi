using lab1movies.Factories;
using lab1movies.Models;
namespace lab1movies.Services
{
    public class MovieService
    {
        private readonly List<Movie> _movies = new()
        {
            new Movie
            {
                Id = 1,
                Title = "Космическая братва",
                Year = 1984,
                Description = "Мэтью Макконохи пытается сбежать от семьи, но спиногрызка дочка достает его даже в 4 измерении",
                PosterPath = "/images/posters/inter.jpg",
                AvailableLanguages = new List<string>
                {
                    "Русский",
                    "Английский"
                },
                LanguageFiles = new Dictionary<string, MovieLanguageFiles>
                {
                    ["Русский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/inter/audio/ru.mp3",
                        Subtitle = "/movies/inter/subtitles/ru.srt"
                    },
                    ["Английский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/inter/audio/en.mp3",
                        Subtitle = "/movies/inter/subtitles/en.srt"
                    }
                }
            },
            new Movie
            {
                Id = 2,
                Title = "Зеленый огр 2",
                Year = 6767,
                Description = "Зеленый огр разрушает монархический строй попутно разрушая многомиллионный бизнес и попадая в тюрьму по 228 ук рф. Откинувшись с зоны со своими друзьями нелегальными мигрантами убивает короля.",
                PosterPath = "/images/posters/kersh.jpg",
                AvailableLanguages = new List<string>
                {
                    "Русский",
                    "Английский"
                },
                LanguageFiles = new Dictionary<string, MovieLanguageFiles>
                {
                    ["Русский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/kersh/audio/ru.mp3",
                        Subtitle = "/movies/kersh/subtitles/ru.srt"
                    },
                    ["Английский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/kersh/audio/en.mp3",
                        Subtitle = "/movies/kersh/subtitles/en.srt"
                    }
                }
            },
            new Movie
            {
                Id = 3,
                Title = "1+1",
                Year = 1337,
                Description = "2",
                PosterPath = "/images/posters/11.jpg",
                AvailableLanguages = new List<string>
                {
                    "Русский",
                    "Английский"
                },
                LanguageFiles = new Dictionary<string, MovieLanguageFiles>
                {
                    ["Русский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/11/audio/ru.mp3",
                        Subtitle = "/movies/11/subtitles/ru.srt"
                    },
                    ["Английский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/11/audio/en.mp3",
                        Subtitle = "/movies/11/subtitles/en.srt"
                    }
                }
            },
            new Movie
            {
                Id = 4,
                Title = "Путешествующие назад и вперед во времени",
                Year = 6969,
                Description = "На самом деле в первой части путешествуют только назад и в настоящее, так что технически название должно быть: путешествие в зад во времени",
                 PosterPath = "/images/posters/backto.jpg",
                AvailableLanguages = new List<string>
                {
                    "Русский",
                    "Английский"
                },
                LanguageFiles = new Dictionary<string, MovieLanguageFiles>
                {
                    ["Русский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/backto/audio/ru.mp3",
                        Subtitle = "/movies/backto/subtitles/ru.srt"
                    },
                    ["Английский"] = new MovieLanguageFiles
                    {
                        Audio = "/movies/backto/audio/en.mp3",
                        Subtitle = "/movies/backto/subtitles/en.srt"
                    }
                }
            }
        };
        public List<Movie> GetMovies()
        {
            return _movies;
        }

        public Movie? GetMovieById(int id)
        {
            return _movies.FirstOrDefault(movie => movie.Id == id);
        }

        public MoviePackage CreatePackage(int movieId, string language)
        {
            Movie? movie = GetMovieById(movieId);

            if (movie == null)
            {
                throw new ArgumentException("Фильм не найден.");
            }

            if (!movie.AvailableLanguages.Contains(language))
            {
                throw new ArgumentException(
                    "Выбранный язык недоступен для этого фильма."
                );
            }

            IPlay factory;

            switch (language)
            {
                case "Русский":
                    factory = new RussianFactory();
                    break;

                case "Английский":
                    factory = new EnglishFactory();
                    break;

                default:
                    throw new ArgumentException("Неизвестный язык.");
            }

            IAudio audio = factory.CreateAudioTrack(movie);
            ISubtitles subtitle = factory.CreateSubtitle(movie);

            if (audio.Language != subtitle.Language)
            {
                throw new InvalidOperationException(
                    "Язык аудио и субтитров не совпадает."
                );
            }

            return new MoviePackage
            {
                Movie = movie,
                AudioTrack = audio,
                Subtitle = subtitle
            };
        }
    }
}
