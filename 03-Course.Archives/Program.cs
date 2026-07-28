using Course.Archives.Models;
using Course.Archives.Services;

var path = "CheckingAccount.txt";

var reader = new AccountFileReader(path);
var accounts = reader.GetCheckingAccounts();

foreach (var account in accounts)
{
    Console.WriteLine($"Account Holder: {account.Holder.Name}\nNumber: {account.Number} | Branch: {account.Branch}\nBalance: {account.Balance}");
}