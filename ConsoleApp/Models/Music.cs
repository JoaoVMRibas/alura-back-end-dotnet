namespace ConsoleApp.Models
{
    internal class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }

        public Music(string name, string artist, int duration, bool isAvailable)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            IsAvailable = isAvailable;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Artist: "+Artist);
            Console.WriteLine("Duration: "+Duration);
            Console.WriteLine("Available: "+IsAvailable);
        }
    }
}
