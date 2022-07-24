// See https://aka.ms/new-console-template for more information

using HomeWork7;
string File = @"O:\sharpProekt\HomeWork\HomeWork7\Users.txt";

Menu menu = new Menu(File);
menu.PrintMenu();
Console.ReadKey();
Loader Loader = new Loader(File);
Loader.Load();
Console.WriteLine($"Содержимое файла {new FileInfo(File).Name}:");
Loader.Print();

Loader.Sort(false);
Loader.Print();
//Loader.AddUser("Сергеев Сергей Сергеевич", 34,187,Convert.ToDateTime("23.12.2020"),"Волгоград");
//Loader.Save();
Console.ReadKey();
//Console.WriteLine("Hello, World!");


void GetMenu()
{
    Console.WriteLine("1. Создание записи " +
                    "\r 2. Просмотр записи " +
                    "\r 3. Редактирование записи " +
                    "\r 4. Сортировка по возрастанию даты" +
                    "\r 5. Сортировка по убыванию даты " +
                    "\r 6. Загрузка записей в выбранном диапазоне дат" +
                    "\r 6. Удаление записи" +
                    "\r 7. ВЫХОД");
}