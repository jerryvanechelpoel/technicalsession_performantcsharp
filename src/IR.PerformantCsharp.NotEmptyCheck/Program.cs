using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: Check if a collection is empty.{0}", Environment.NewLine);

string[] values = new[] { "HoMeR SiMpSoN", "MaRgE bOuViEr", "BaRt SiMpSoN", "LiSa SiMpSoN", "MaGgIe SiMpSoN" };

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        bool result = values.Any();
    }

    sw.Stop();
    Console.WriteLine("Any() costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        bool result = values.Length > 0;
    }

    sw.Stop();
    Console.WriteLine("Length > 0 costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}