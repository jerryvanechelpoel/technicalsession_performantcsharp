using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: Check if an item exists and fetch it from the collection.{0}", Environment.NewLine);

string findValue = "BaRt SiMpSoN";
string[] values = new[] { "HoMeR SiMpSoN", "MaRgE bOuViEr", "BaRt SiMpSoN", "LiSa SiMpSoN", "MaGgIe SiMpSoN" };

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        if (values.Any(item => item.Equals(findValue, StringComparison.OrdinalIgnoreCase)))
        {
            string? simpson = values.FirstOrDefault(item => item.Equals(findValue, StringComparison.OrdinalIgnoreCase));
        }
    }

    sw.Stop();
    Console.WriteLine("Any() and FirstOrDefault() costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        string? simpson = values.FirstOrDefault(item => item.Equals(findValue, StringComparison.OrdinalIgnoreCase));

        if (simpson != null)
        {
            
        }
    }

    sw.Stop();
    Console.WriteLine("Null check costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}