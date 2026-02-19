using ScreenSound_API.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var options = new JsonSerializerOptions 
        {
            PropertyNameCaseInsensitive = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        }; 

        List<Music>? musics = JsonSerializer.Deserialize<List<Music>>(response, options)!;

        //if (musics != null) 
        //{
        //    foreach (var music in musics ?? new List<Music>())
        //    {
        //        music.ShowSongDetails();
        //    }
        //}
        //LinqFilter.FilterAllGenresMusics(musics);
        //LinqOrder.ShowListOfArtistsSorted(musics);
        //LinqFilter.FilterArtistsByGenreMusical(musics, "pop");
        LinqFilter.FilterMusicsByAnArtist(musics, "U2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}