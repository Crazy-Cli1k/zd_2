using System;
using System.IO;

namespace zd_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputFile = "input.txt";
            string OutputFile = "output.txt";
            if (File.Exists(InputFile))
            {
                try
                {
                    int Day;
                    if (Int32.TryParse(File.ReadAllText(InputFile), out Day))
                    {
                        int StudentDay = Day + 3 < 7 ? Day + 3 : Day + 3 - 7;

                        File.WriteAllText(OutputFile, StudentDay.ToString());
                    }
                    else { Console.WriteLine("Номер дня недели в неверном формате!"); Console.ReadKey(); Environment.Exit(0); }
                }
                catch { Console.WriteLine("Что-то пошло не так!"); }
            }else Console.WriteLine("Файл не найден!");
        }
    }
}
