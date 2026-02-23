
using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

public class Music
{
    private string[] shades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};
    public string? Artist { get; set; }
    public string? Song { get; set; }

    [JsonPropertyName("duration_ms")]
    public int DurationMs { get; set; }
    public string? Explicit { get; set; }
    public int Year { get; set; }
    public int Popularity { get; set; }
    public double Danceability { get; set; }
    public double Energy { get; set; }
    public int Key { get; set; }
    public string Shade { get
        {
            return shades[Key];
        }}
    public double Loudness { get; set; }
    public int Mode { get; set; }
    public double Speechiness { get; set; }
    public double Acousticness { get; set; }
    public double Instrumentalness { get; set; }
    public double Liveness { get; set; }
    public double Valence { get; set; }
    public double Tempo { get; set; }
    public string? Genre { get; set; }

    public void ShowSongDetails() 
    {
        Console.WriteLine($"{Artist} - {Song} ({Year})");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Popularity: {Popularity}");
        Console.WriteLine($"Duration: {DurationMs / 1000}s");
        Console.WriteLine($"Shade: {Shades(Key)}");
        Console.WriteLine();
    }

    public string Shades(int key) 
    {
        if (key >= 0 && key < shades.Length) 
        {
            return shades[key];
        }
        
        return key.ToString();
    }
}
