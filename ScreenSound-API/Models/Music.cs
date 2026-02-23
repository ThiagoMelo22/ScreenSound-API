
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
        Console.WriteLine($"DurationMs: {DurationMs / 1000}");
        Console.WriteLine($"Shade: {Shades(Key)}");
        Console.WriteLine();
    }

    public string Shades(int key) 
    {
        string result;
        switch (key)
        {
            case 0:
                result = "C";
                break;
            case 1:
                result = "C#";
                break;
            case 2:
                result = "D";
                break;
            case 3:
                result = "D#";
                break;
            case 4:
                result = "E";
                break;
            case 5:
                result = "F";
                break;
            case 6:
                result = "F#";
                break;
            case 7:
                result = "G";
                break;
            case 8:
                result = "G#";
                break;
            case 9:
                result = "A";
                break;
            case 10:
                result = "A#";
                break;
            case 11:
                result = "B";
                break;
            default:
                result = $"{ Key}";
                break;
        }

        return result;
    }
}
