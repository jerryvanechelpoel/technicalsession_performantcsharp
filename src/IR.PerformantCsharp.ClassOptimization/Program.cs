using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: Sealed class vs. inheritable class.{0}", Environment.NewLine);

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        MyInheritableClass instance = new();
        instance.GetMeAValue();
    }

    sw.Stop();
    Console.WriteLine("Calls on inheritable class costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        MySealedClass instance = new();
        instance.GetMeAValue();
    }

    sw.Stop();
    Console.WriteLine("Calls on sealed costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}