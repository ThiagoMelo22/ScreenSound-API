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
}
