﻿using System;
using System.Diagnostics;
using System.IO;

namespace conconcon_tri_buter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{Environment.CurrentDirectory}");
            Console.Write("How much days you want to contribute? : ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("How many contribution one day pushed ('r' - random) : ");
            string rst = Console.ReadLine();
            bool random = rst == "r";
            int cons = random ? -1 : int.Parse(rst);

            Console.WriteLine("\nPress any key to continue ...\n");
            Console.ReadLine(); Console.WriteLine();

            DateTime dt = DateTime.Now, now = DateTime.Now;
            dt -= new TimeSpan(days, 0, 0, 0);
            while(dt.Year != now.Year || dt.Month != now.Month || dt.Day != now.Day)
            {
                Console.WriteLine($"date: {dt:yyyy-MM-dd} | start commit!");
                for (int i = 1; i <= (random ? rand.Next(5, 9) : cons); ++ i)
                    generatefile(dt);
                dt = dt.AddDays(1);
            }

            Console.WriteLine("\n\nFinished! Go to your GitHub to see 13 !");
        }

        private static void generatefile(DateTime dt)
        {
            string fn = $"{Environment.CurrentDirectory}\\{randomname()}.txt";

            Console.WriteLine($"generate: {Path.GetFileName(fn)}");

            if (File.Exists(fn))
                File.Delete(fn);
            FileStream fs = File.Create(fn);
            StreamWriter sw = new(fs);
            sw.WriteLine(randomname());
            sw.Flush();
            sw.Close(); fs.Close();

            normalCommit(dt);

            File.Delete(fn);

            normalCommit(dt);

            Console.WriteLine($"delete: {Path.GetFileName(fn)}");
        }

        private static void normalCommit(DateTime dt)
        {
            runGit(" add .");
            runGit($" commit -m \"{randomname()}\" --date {dt:yyyy/MM/dd}");
        }

        private static void runGit(string args)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = "git.exe";
                myProcess.StartInfo.Arguments = args;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                myProcess.WaitForExit();
            }
        }

        static Random rand = new();

        private static string randomname()
        {
            int length = 8;
            string rst = "";
            for (int i = 1; i <= length; ++ i)
                rst += rand.Next(0, 1) == 0 ? ((char)('A' + rand.Next(0, 25))).ToString() : ((char)('a' + rand.Next(0, 25))).ToString();
            return rst;
        }
    }
}
