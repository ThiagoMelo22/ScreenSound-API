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

    public static void FilterMusicByYear(List<Music> musics, int year) 
    {
        var musicsOfYear = musics
            .Where(m => m.Year == year)
            .Select(m => m.Song)
            .Distinct()
            .OrderBy(a => a)
            .ToList();

        Console.WriteLine($"Músicas de {year}");
        foreach (var music in musicsOfYear) 
        {
            Console.WriteLine($"- {music}");
        }
    }

    public static void FilterMusicInCSharp(List<Music> musics) 
    {
        var musicsInCSharp = musics
            .Where(m => m.Shade.Equals("C#"))
            .Select(m => m.Song)
            .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var music in musicsInCSharp) 
        {
            Console.WriteLine($"- {music}");
        }
    }

    //Exemplos:
    //LinqFilter.FilterAllGenresMusics(musics);
    //LinqOrder.ShowListOfArtistsSorted(musics);
    //LinqFilter.FilterArtistsByGenreMusical(musics, "pop");
    //LinqFilter.FilterMusicsByAnArtist(musics, "U2");
    //LinqFilter.FilterMusicByYear(musics, 2012);
    //LinqFilter.FilterMusicInCSharp(musics);
}
