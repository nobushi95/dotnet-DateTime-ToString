using System.Globalization;

namespace dotnet_DateTime_ToString;

internal class Program
{
    private static readonly string Format = "yyyy/MM/dd HH:mm:ss";

    static void Main(string[] args)
    {
        while (true)
        {
            var now = DateTime.UtcNow;
            Console.WriteLine($"ja-JP:     {now.ToString(Format, new CultureInfo("ja-JP"))}");
            Console.WriteLine($"en-US:     {now.ToString(Format, new CultureInfo("en-US"))}");
            Console.WriteLine($"invariant: {now.ToString(Format, CultureInfo.InvariantCulture)}");

            Console.WriteLine("if you want to exit program, type \"q\".");

            var c = Console.ReadLine();
            if (c is "q" or "exit" or "quit")
                break;
        }
    }
}
