using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: compare strings with and without mutations.{0}", Environment.NewLine);

string findValue = "Lisa Simpson";
string[] values = new[] { "HoMeR SiMpSoN", "MaRgE bOuViEr", "BaRt SiMpSoN", "LiSa SiMpSoN", "MaGgIe SiMpSoN" };

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        foreach(string value in values)
        {
            if(value.ToUpper() == findValue.ToUpper())
            {
                continue;
            }
        }
    }

    sw.Stop();
    Console.WriteLine("String comparison with ToUpper() costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        foreach (string value in values)
        {
            if (value.Equals(findValue, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }
        }
    }

    sw.Stop();
    Console.WriteLine("String comparison with OrdinalIgnoreCase costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}