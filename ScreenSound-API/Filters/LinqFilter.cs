using ScreenSound_API.Models;
using System.Linq;

namespace ScreenSound_API.Filters;

internal class LinqFilter
{
    public static void FilterAllGenresMusics(List<Music> musics) 
    {
        var allGenresMusics = musics
            .Select(genres => genres.Genre)
            .Distinct()
            .ToList();
        foreach (var genre in allGenresMusics) 
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistsByGenreMusical(List<Music> musics, string genre) 
    {
        var artistsByGenreMusical = musics
            .Where(m => m.Genre!.Contains(genre))
            .Select(m => m.Artist)
            .Distinct()
            .OrderBy(a => a)
            .ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genre}");
        foreach (var artist in artistsByGenreMusical) 
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicsByAnArtist(List<Music> musics, string nameArtist) 
    {
        var musicArtist = musics
            .Where(m => m.Artist!.Equals(nameArtist))
            .ToList();
        Console.WriteLine($"{nameArtist}");
        foreach (var music in musicArtist) 
        {
            Console.WriteLine($"- {music.Song}");
        }
    }
}
