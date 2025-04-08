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

        Console.WriteLine("Файлне успешно создан и записан.");
    }
}
