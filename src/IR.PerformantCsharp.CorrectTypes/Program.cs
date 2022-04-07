using System.Diagnostics;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: iterating {0:N} items through IEnumerable<T> vs. T[].{1}", iterations, Environment.NewLine);

var array = new string[iterations];

for (int i = 0; i < array.Length; i++)
{
    array[i] = i.ToString();
}

IEnumerable<string> ienumerable = array;

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    foreach (string s in ienumerable)
    { }

    sw.Stop();
    Console.WriteLine("Enumerable iterations costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    foreach (string s in array)
    { }

    sw.Stop();

    Console.WriteLine("Array iterations costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}