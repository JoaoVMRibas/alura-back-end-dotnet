using System.Text;

namespace Course.Archives.Services;

internal class AccountFileReader
{
    private readonly string _filePath;

    public AccountFileReader(string filePath)
    {
        _filePath = filePath;
    }

    public void ReadAndDisplayFile()
    {
        if(!File.Exists(_filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (var fs = new FileStream(_filePath, FileMode.Open))
        {
            var reader = new StreamReader(fs);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
