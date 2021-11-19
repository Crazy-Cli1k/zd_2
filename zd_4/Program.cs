using System;
using System.IO;
using System.Collections;

namespace zd_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputFile = "input.txt";
            string OutputFile = "output.txt";

            if (File.Exists(InputFile))
            {
                ArrayList STR = new ArrayList();
                StreamReader sr = new StreamReader(InputFile);
                string STR_1 = sr.ReadLine();
                int k = 0;

                try
                {
                    k = int.Parse(STR_1.Split(" ")[1]);
                }
                catch { Environment.Exit(0); }

                if (k < 1 || k > Math.Pow(10, 5))
                { Environment.Exit(0); };

                while (!sr.EndOfStream)
                {
                    STR.Add(sr.ReadLine());
                }

                STR.Remove(0);

                try
                {
                    for (int i = 0; i < STR.Count; i++)
                    {
                        int Year = int.Parse(STR[i].ToString().Split(" ")[0].Split("-")[0]);
                        if (Year < 1600 || Year > 2500) break;
                        int Month = int.Parse(STR[i].ToString().Split(" ")[0].Split("-")[1]);
                        if (Month < 1 || Month > 12) break;
                        int Day = int.Parse(STR[i].ToString().Split(" ")[0].Split("-")[2]);
                        if (Day < 1 || Day > 31) break;
                        int Hour = int.Parse(STR[i].ToString().Split(" ")[1].Split(":")[0]);
                        if (Hour < 0 || Hour > 23) break;
                        int Minute = int.Parse(STR[i].ToString().Split(" ")[1].Split(":")[1]);
                        if (Minute < 0 || Minute > 59) break;
                        int Second = int.Parse(STR[i].ToString().Split(" ")[1].Split(":")[2]);
                        if (Second < 0 || Second > 59) break;
                    }
                }
                catch { Environment.Exit(0); }

                int n = STR.Count;

                if (n != int.Parse(STR_1.Split(" ")[0]))
                    Environment.Exit(0); ;

                STR.Sort();

                foreach (object e in STR)
                {
                    Console.WriteLine(e);
                }

                string OutputString = STR[k - 1].ToString();

                Console.WriteLine();
                Console.WriteLine(OutputString);
                sr.Close();
                StreamWriter sw = new StreamWriter(OutputFile);
                sw.WriteLine(STR[k - 1].ToString());
                sw.Close();

                Console.ReadKey();
            }
            else Console.WriteLine("Файл не найден!");
        }
    }
}
