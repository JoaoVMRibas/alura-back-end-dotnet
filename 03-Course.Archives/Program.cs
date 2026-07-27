using Course.Archives.Services;

var path = "CheckingAccount.txt";

var reader = new AccountFileReader(path);
reader.ReadAndDisplayFile();
