using ScreenSound_API.Models;
using System.Linq;

namespace ScreenSound_API.Filters;

internal class LinqOrder
{
    public static void ShowListOfArtistsSorted(List<Music> musics) 
    {
        var ordainedArtits = musics
            .Select(m => m.Artist)
            .Distinct()
            .OrderBy(a => a)
            .ToList();
        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artist in ordainedArtits) 
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
