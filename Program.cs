using System;
using System.IO;
using System.Diagnostics;
class Functional
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        using (StreamReader sr = new StreamReader(new BufferedStream(File.OpenRead("D:\\Study\\Third Course\\FP\\statistic.txt"), 1024 * 1024)))
        {
            string line;
            int n1 = Int32.Parse(sr.ReadLine());
            int n2 = Int32.Parse(sr.ReadLine());
            int n3 = Int32.Parse(sr.ReadLine());
            int n4 = Int32.Parse(sr.ReadLine());
            int n5;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                n5 = Int32.Parse(line);
                if (n3 > n1)
                    if (n3 > n2)
                        if (n3 > n4)
                            if (n3 > n5)
                            {
                                count = count + 1;
                            }
                n1 = n2;
                n2 = n3;
                n3 = n4;
                n4 = n5;
            }
            stopwatch.Stop();
            Console.WriteLine($"Number of groups with the third number greater than the others: {count}");
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey(true);
        }

    }
}