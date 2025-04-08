using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "testfile.txt";
        string content = "Тестовий файл з текстом";

        // Запись текста в файл
        File.WriteAllText(filePath, content);

        Console.WriteLine("Файл не создан и записан.");
    }
}
