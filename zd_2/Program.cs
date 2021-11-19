using System;
using System.IO;

namespace zd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputFile = "input.txt";
            string OutputFile = "output.txt";
            if (File.Exists(InputFile))
            {
                string[] STR = File.ReadAllLines(InputFile);
                int MAXPATH = int.Parse(STR[0].Split(" ")[0]);
                int Checker = 0;
                int str_1 = MAXPATH;

                foreach (string n in STR[1].Split(" "))
                {
                    if (str_1 - int.Parse(n) < 0)
                    {
                        str_1 = MAXPATH - int.Parse(n);
                        ++Checker;
                    }
                    else if (str_1 - int.Parse(n) == 0)
                    {
                        str_1 = MAXPATH;
                        ++Checker;
                    }
                    else
                    {
                        str_1 -= int.Parse(n);
                    }
                }

                if (str_1 < 10) 
                Checker++;

                File.WriteAllText(OutputFile, Checker.ToString());
            }
            else Console.WriteLine("Файл не найден!");
        }
    }

}
