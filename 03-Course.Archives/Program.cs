using Course.Archives.Services;

try
{
    var path = "ExportedCheckingAccounts.csv";
    var writer = new AccountFileWriter(path);

    writer.CreateCSVFile("321,1344,4242.45,Pedro");

    Console.WriteLine("Success");
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}