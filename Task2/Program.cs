using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string data = "Hello world";

        Process process = new Process();
        process.StartInfo.FileName = "путь_к_первой_программе.exe";
        process.StartInfo.Arguments = data;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;

        process.Start();
        process.WaitForExit();

        int exitCode = process.ExitCode;

        if (exitCode == 0)
        {
            Console.WriteLine("Запись файла выполнена успешно.");
        }
        else
        {
            Console.WriteLine("Запись файла не удалась.");
        }
    }
}