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
}
