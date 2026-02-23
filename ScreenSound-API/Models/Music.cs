
using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

public class Music
{
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
        Console.WriteLine($"DurationMs: {DurationMs / 1000}");
        switch (Key) 
        {
            case 0:
                Console.WriteLine("Key: C");
                break;
            case 1: 
                Console.WriteLine("Key: C#");
                break;
            case 2: 
                Console.WriteLine("Key: D");
                break;
            case 3: 
                Console.WriteLine("Key: D#");
                break;
            case 4:
                Console.WriteLine("Key: E");
                break;
            case 5: 
                Console.WriteLine("Key: F");
                break;
            case 6:
                Console.WriteLine("Key: F#");
                break;
            case 7:
                Console.WriteLine("Key: G");
                break;
            case 8:
                Console.WriteLine("Key: G#");
                break;
            case 9:
                Console.WriteLine("Key: A");
                break;
            case 10:
                Console.WriteLine("Key: A#");
                break;
            case 11:
                Console.WriteLine("Key: B");
                break;
            default:
                Console.WriteLine($"Key: {Key}");
                break;
        }
        Console.WriteLine();
    }
}
