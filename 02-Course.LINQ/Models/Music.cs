using System.Text.Json.Serialization;

namespace Course.LINQ.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    public void DisplayInformation()
    {
        Console.WriteLine($"Song: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duration in seconds: {Duration/1000}");
    }
}
