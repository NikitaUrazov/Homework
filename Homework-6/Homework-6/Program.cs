using System;
using System.Diagnostics;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine(processes[i].Id + " " + processes[i].ProcessName);
            }

            Console.Write("Введите id или имя процесса для завершения: ");
            string input = Console.ReadLine();

            int pid;
            if (int.TryParse(input, out pid))
                KillById(pid);
            else
                KillByName(input);
        }

        static void KillById(int pid)
        {
            if (pid == 0)
            {
                Console.WriteLine("Невозможно завершить idle процесс");
                return;
            }

            Process process = Process.GetProcessById(pid);
            process.Kill();
        }

        static void KillByName(string pname)
        {
            if (pname == "Idle")
            {
                Console.WriteLine("Невозможно завершить idle процесс");
                return;
            }

            Process[] processes = Process.GetProcessesByName(pname);
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].Id == 0)
                {
                    Console.WriteLine("Попытка завершить idle процесс.");
                    continue;
                }
                else
                    processes[i].Kill();
            }
        }
    }
}
