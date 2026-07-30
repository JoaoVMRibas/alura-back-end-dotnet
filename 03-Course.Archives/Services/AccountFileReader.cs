using Course.Archives.Models;

namespace Course.Archives.Services;

internal class AccountFileReader
{
    private readonly string _filePath;

    public AccountFileReader(string filePath)
    {
        _filePath = filePath;
    }

    public List<CheckingAccount> GetCheckingAccounts()
    {
        if (!File.Exists(_filePath))
            throw new InvalidOperationException("File not found");

        using (var fs = new FileStream(_filePath, FileMode.Open))
        {
            using var reader = new StreamReader(fs);
            var accounts = new List<CheckingAccount>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(line))
                    accounts.Add(ConvertToCheckingAccount(line));
            }
            return accounts;
        }
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
            using var reader = new StreamReader(fs);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }

    private static CheckingAccount ConvertToCheckingAccount(string line)
    {
        var fields = line.Split(',');
        var number = int.Parse(fields[0]);
        var branch = int.Parse(fields[1]);
        var balance = double.Parse(fields[2].Replace('.',','));
        var holder = fields[3];

        var account = new CheckingAccount(number, branch, new Client(holder));
        account.Deposit(balance);

        return account;
    }
}
