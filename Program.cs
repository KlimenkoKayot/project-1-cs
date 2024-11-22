using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using static CustomMethods;

class Program
{
    static List<Student> data;
    static bool isHaveData = false;

    static void Exit()
    {
        Console.WriteLine("\nНажмите любую кнопку...");
        var exitKey = System.Console.ReadKey(true);
    }

    static void Main()
    {
       
        for (; ;)
        {
            Console.WriteLine(isHaveData ? "1. Сменить набор данных" : "1. Загрузить данные");
            Console.WriteLine("2. Вывести информацию обо всех студентов, чьи родители учились на оценки >= 4");

            var key = System.Console.ReadKey(true);

            // Обработка подключения/обновления файла
            if (key.KeyChar == '1') {
                Console.Clear();
                Console.WriteLine("Введите путь к файлу .csv");
                string filePath = Console.ReadLine();
                try
                {
                    data = ReadFile(filePath);
                    isHaveData = true;
                }
                catch (Exception ex) 
                {
                    Console.Clear(); 
                    Console.WriteLine(ex.Message);
                    Exit();
                }
            } 
            if (key.KeyChar == '2')
            {
                Console.Clear();
                if (!isHaveData)
                {
                    Console.WriteLine("Необходимо подключить файл");
                    Exit();
                } 
                else
                {
                    foreach (Student student in data)
                    {
                        if (student.GetMedu() >= 4.0 && student.GetFedu() >= 4.0) 
                        {
                            student.Print();
                        } 
                    }
                    Exit();
                }
            }

            // Чистим консоль от предыдущего вывода меню
            Console.Clear();
        }
    }
}