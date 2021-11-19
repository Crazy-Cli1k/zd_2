using System;
using System.IO;

namespace zd_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputFile = "input.txt";
            string OutputFile = "output.txt";

            if (File.Exists(InputFile))
            {
                StreamReader sr = new StreamReader(InputFile);
                string str_2 = null;
                bool Checker = false;
                while (!sr.EndOfStream) 
                { str_2 += sr.ReadLine(); }
                sr.Close();

                if (str_2 == null) 
                { Checker = true; }

                for (int i = 0; i < str_2.Length; i++)
                {
                    if (str_2[i] != '1' && str_2[i] != '0') Checker = true;
                }
                if (Checker == false)
                {
                    string str_1 = null;
                    int n = 0;
                    int count = 0;

                    for (int i = 0; i < str_2.Length / 8; i++)
                    {
                        str_1 = str_2.Substring(n, 8);
                        if (str_1.Substring(0, 2) != "10")
                        count++;
                        n += 8;
                    }

                    StreamWriter sw = new StreamWriter(OutputFile);

                    if (!File.Exists(OutputFile))
                    {
                        File.Create(OutputFile).Dispose();
                    }
                    sw.WriteLine(count);
                    sw.Close();

                    Console.ReadKey();
                }
                else if (Checker == true)
                {
                    Console.WriteLine("Строка содержит недопустимые символы");
                }
            }
            else Console.WriteLine("Такого файла нет!");
        }
    }
}
