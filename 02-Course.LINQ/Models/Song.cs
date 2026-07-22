using System.Text.Json.Serialization;

namespace Course.LINQ.Models;

internal class Song
{
    private static readonly string[] Keys =
    {
        "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
    };

    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("key")]
    public int NumericKey { private get; set; }
    [JsonIgnore]
    public string Key => (NumericKey >= 0 && NumericKey < Keys.Length) 
        ? Keys[NumericKey]
        : "Unknown";

    public void DisplayInformation()
    {
        Console.WriteLine($"Song: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duration in seconds: {Duration/1000}");
        Console.WriteLine($"Key: {Key}");
    }
}
