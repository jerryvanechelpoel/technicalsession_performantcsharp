using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: create and populate list with {0} items with and without capacity.{1}", iterations, Environment.NewLine);

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    List<string> list1 = new();

    for (int j = 0; j < iterations; j++)
    {
        list1.Add(j.ToString());
    }

    sw.Stop();
    Console.WriteLine("List creation without capacity costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    List<string> list2 = new(iterations);

    for (int j = 0; j < iterations; j++)
    {
        list2.Add(j.ToString());
    }

    sw.Stop();
    Console.WriteLine("List creation with capacity costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}