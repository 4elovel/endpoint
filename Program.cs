using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
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