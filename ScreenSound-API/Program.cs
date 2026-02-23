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

        var musicsPrefereds = new MusicsPrefered("Thiago");
        musicsPrefereds.AddFavoriteSongs(musics[1]);
        musicsPrefereds.AddFavoriteSongs(musics[377]);
        musicsPrefereds.AddFavoriteSongs(musics[4]);
        musicsPrefereds.AddFavoriteSongs(musics[6]);
        musicsPrefereds.AddFavoriteSongs(musics[1467]);

        musicsPrefereds.ShowFavoriteSongs();

        var musicsPreferedsEve = new MusicsPrefered("Evelyn");
        musicsPreferedsEve.AddFavoriteSongs(musics[500]);
        musicsPreferedsEve.AddFavoriteSongs(musics[637]);
        musicsPreferedsEve.AddFavoriteSongs(musics[428]);
        musicsPreferedsEve.AddFavoriteSongs(musics[13]);
        musicsPreferedsEve.AddFavoriteSongs(musics[71]);

        musicsPreferedsEve.ShowFavoriteSongs();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}