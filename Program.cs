// See https://aka.ms/new-console-template for more information

using HomeWork7;
using System.Globalization;
string File = @"O:\sharpProekt\HomeWork\HomeWork7\Users.txt";

Repository repository = new Repository(File);
worker[] arr= repository.GetWorkersBetweenTwoDates(Convert.ToDateTime("12.12.2020"),Convert.ToDateTime("12.12.2023"));
arr.OrderBy(w => w.FIO);
bool isRepeat = true;
while (isRepeat)
{
    Console.WriteLine($"{Environment.NewLine}МЕНЮ:");
    Console.WriteLine("\n\t[0] - Очистить консоль" +
                        "\n\t[1] - Вывести все записи" +
                        "\n\t[2] - Добавить запись" +
                        "\n\t[3] - Удалить запись" +
                        "\n\t[4] - Вывести записи в диапазоне дат" +
                        "\n\t[5] - Сортировать записи" +
                        "\n\t[6] - ВЫХОД");
    Console.WriteLine("Введите номер пункта:");
    switch (Console.ReadLine())
    {
        case "0":
            Console.Clear();
            break;
        case "1":
            Print(repository.GetAllWorkers());
            break;
        case "2":
            worker tmp = new worker();
            tmp.FIO = FieldUserName();
            tmp.Age = FieldAge();
            tmp.Height = FieldHeight();
            tmp.DateOfBirth = FieldDateOfBirth();
            tmp.PlaceOfBirth = FieldPlaceOfBirth();
            repository.AddWorker(tmp);
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            isRepeat = false;
            break;
        default:
            Console.WriteLine("Команда не опознана");
            break;
    }
}

static void Print(worker[] arr)
{
    if (arr.Length > 0)
    {
        Console.WriteLine($"\tID\tДата и время добавления\tФИО\t\t\t\tВозраст\tРост\tДата рождения\tМесто рождения");
        foreach (worker item in arr)
        {
            Console.WriteLine($"\t{item.Id:00}\t{item.DateCreate}\t{item.FIO,-25}\t{item.Age}" +
                            $"\t{item.Height}\t{item.DateOfBirth:dd.MM.yyyy}\t{item.PlaceOfBirth}");

        }
    }
    else { Console.WriteLine("Записи отсутствуют!"); }
}
static string FieldUserName()
{
    Console.WriteLine($"Заполните поле - ФИО:");
    return Console.ReadLine();
}
static int FieldAge()
{
    Console.WriteLine($"Заполните поле - Возраст:");
    return int.Parse(Console.ReadLine());
}
static int FieldHeight()
{
    Console.WriteLine($"Заполните поле - Рост:");
    return int.Parse(Console.ReadLine());
}
static DateTime FieldDateOfBirth()
{
    Console.WriteLine($"Заполните поле - Дата рождения:");
    return DateTime.Parse(Console.ReadLine());
}
static string FieldPlaceOfBirth()
{
    Console.WriteLine($"Заполните поле - Место рождения:");
    return Console.ReadLine();
}
//Menu menu = new Menu(File);
//menu.PrintMenu();
//menu.Work();
//Console.ReadKey();
//Loader Loader = new Loader(File);