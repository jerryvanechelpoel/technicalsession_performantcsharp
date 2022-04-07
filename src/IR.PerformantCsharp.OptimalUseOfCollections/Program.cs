using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: creating {0:N} empty arrays vs. {0:N} Array.Empty<T>().{1}", iterations, Environment.NewLine);

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        var array = new string[0];
    }

    sw.Stop();
    Console.WriteLine("Empty array creation costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        var array = Array.Empty<string>();
    }

    sw.Stop();
    Console.WriteLine("Array.Empty<T>() costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}