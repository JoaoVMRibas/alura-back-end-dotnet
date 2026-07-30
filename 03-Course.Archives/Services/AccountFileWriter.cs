namespace Course.Archives.Services;

internal class AccountFileWriter
{
    private readonly string _filePath;

    public AccountFileWriter(string filePath)
    {
        _filePath = filePath;
    }

    public void CreateCSVFile(string accountData)
    {
        using (var fs = new FileStream(_filePath, FileMode.CreateNew))
        {
            using var writer = new StreamWriter(fs);

            writer.Write(accountData);
        }
        
    }
}
