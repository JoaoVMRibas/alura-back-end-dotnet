namespace ConsoleApp.Models
{
    internal class Music
    {
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }

        public Music(string name, Artist artist, int duration, bool isAvailable)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            IsAvailable = isAvailable;

            Artist.Musics.Add(this);
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"--- Music : {Name} ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Artist: " + Artist.Name);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Available: " + IsAvailable);
            Console.WriteLine();
        }
    }
}
