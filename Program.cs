using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Введіть IP адрес:");
        string str = Console.ReadLine();
        try
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(str), 80);
            Console.WriteLine($"кінцева точка - {endPoint.Address}:{endPoint.Port} створена");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wrong IP format");
        }

    }
}