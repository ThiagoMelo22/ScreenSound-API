using System.Text.Json;

namespace ScreenSound_API.Models;

internal class MusicsPrefered
{
    public string? Name { get; set; }
    public List<Music> ListMusics { get; }

    public MusicsPrefered(string name) 
    {
        Name = name;
        ListMusics = new List<Music>();
    }

    public void AddFavoriteSongs(Music music) 
    {
        ListMusics.Add(music);
    }

    public void ShowFavoriteSongs() 
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Name}");
        foreach (var music in ListMusics) 
        {
            Console.WriteLine($"- {music.Song} de {music.Artist}");
        }
        Console.WriteLine();
    }

    public void GenerateJSONFile() 
    {
        string json = JsonSerializer.Serialize(new 
        {
            name = Name,
            musics = ListMusics
        });

        string nameOfArquive = $"musicas-favoritas-{Name}.json";
        File.WriteAllText(nameOfArquive, json);
        Console.WriteLine($"O Arquivo Json foi criado com sucesso! {Path.GetFullPath(nameOfArquive)}");
    }

    // Exemplos para utilizar no program.cs
    //var musicsPrefereds = new MusicsPrefered("Thiago");
    //musicsPrefereds.AddFavoriteSongs(musics[1]);
    //musicsPrefereds.AddFavoriteSongs(musics[377]);
    //musicsPrefereds.AddFavoriteSongs(musics[4]);
    //musicsPrefereds.AddFavoriteSongs(musics[6]);
    //musicsPrefereds.AddFavoriteSongs(musics[1467]);

    //musicsPrefereds.ShowFavoriteSongs();

    //var musicsPreferedsEve = new MusicsPrefered("Evelyn");
    //musicsPreferedsEve.AddFavoriteSongs(musics[500]);
    //    musicsPreferedsEve.AddFavoriteSongs(musics[637]);
    //    musicsPreferedsEve.AddFavoriteSongs(musics[428]);
    //    musicsPreferedsEve.AddFavoriteSongs(musics[13]);
    //    musicsPreferedsEve.AddFavoriteSongs(musics[71]);

    //    musicsPreferedsEve.ShowFavoriteSongs();
    //    musicsPreferedsEve.GenerateJSONFile();
}
