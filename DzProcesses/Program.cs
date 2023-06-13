using System;
using System.IO;

class Program
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Необходимо передать строку данных в аргументах командной строки.");
            return 1;
        }

        string data = args[0];
        string filePath = "output.txt";

        try
        {
            File.WriteAllText(filePath, data);
            Console.WriteLine("Запись файла выполнена успешно.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при записи файла: " + ex.Message);
            return 1;
        }
    }
}