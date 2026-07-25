using System.Text;

var path = "CheckingAccount.txt";

using (var fs = new FileStream(path, FileMode.Open))
{
    var buffer = new byte[1024];
    var qTBytes = -1;

    while (qTBytes != 0)
    {
        qTBytes = fs.Read(buffer, 0, 1024);

        WriteBuffer(buffer, qTBytes);
    }
}

static void WriteBuffer(byte[] buffer, int qTBytes)
{
    var encoding = new UTF8Encoding();
    var text = encoding.GetString(buffer, 0, qTBytes);
    Console.Write(text);
}