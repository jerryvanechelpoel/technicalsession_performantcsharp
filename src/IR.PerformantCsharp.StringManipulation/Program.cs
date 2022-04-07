using System.Diagnostics;
using System.Text;

const int iterations = 1_000_000;

Console.WriteLine("Comparison: compare string manipulations.{0}", Environment.NewLine);

string[] firstNames = new[] { "Homer", "Bart", "Lisa", "Maggie", "Abe" };
string lastName = "Simpson";

for (int i = 0; i < 10; i++)
{
    Stopwatch sw = Stopwatch.StartNew();

    for (int j = 0; j < iterations; j++)
    {
        foreach (string firstName in firstNames)
        {
            string fullName = firstName + " " + lastName;
        }
    }

    sw.Stop();
    Console.WriteLine("String concatenation costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        foreach (string firstName in firstNames)
        {
            string fullName = $"{firstName} {lastName}";
        }
    }

    sw.Stop();
    Console.WriteLine("String interpolation costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        foreach (string firstName in firstNames)
        {
            StringBuilder sb = new();
            sb.Append(firstName).Append(' ').Append(lastName);
            string fullName = sb.ToString();
        }
    }

    sw.Stop();

    Console.WriteLine("StringBuilder costs {0} ms ({1} ticks)", sw.ElapsedMilliseconds, sw.ElapsedTicks);

    sw.Restart();

    for (int j = 0; j < iterations; j++)
    {
        foreach (string firstName in firstNames)
        {
            string fullName = string.Format("{0} {1}", firstName, lastName);
        }
    }

    sw.Stop();

    Console.WriteLine("String.Format costs {0} ms ({1} ticks){2}", sw.ElapsedMilliseconds, sw.ElapsedTicks, Environment.NewLine);
}