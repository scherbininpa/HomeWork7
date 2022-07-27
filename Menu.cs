using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{

    struct Menu
    {
        string[] MenuItems;
        private Loader ObjLoader;
        public Menu(string Path)
        { 
            ObjLoader = new Loader(Path);
            MenuItems = new string[] { "Создание записи", 
                                        "Просмотр записи", 
                                        "Редактирование записи", 
                                        "Сортировка по возрастанию даты",
                                        "Сортировка по убыванию даты",
                                        "Загрузка записей в выбранном диапазоне дат",
                                        "Удаление записи",
                                        "ВЫХОД" };
            //ObjLoader.Load();
            ObjLoader.Print();
        }

        public void Work()
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                ObjLoader.Print();
                PrintMenu();
                isRepeat = ReadKeyAnsver();
            }
        }
        private bool ReadKeyAnsver()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            { 
                case '1':
                    ObjLoader.AddUser(FieldUserName(), FieldAge(), FieldHeight(), FieldDateOfBirth(), FieldPlaceOfBirth());
                    return true;
                    break;
                case '2':
                    return true;
                    break;
                case '3':
                    return true;
                    break;
                case '4':
                    return true;
                    break;
                case '5':
                    return true;
                    break;
                case '6':
                    return true;
                    break;
                case '7':
                    return true;
                    break;
                case '8':
                    return false;
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}Пункт меню не найден!");
                    return true;
                    break;
            }
        }

        private string FieldUserName()
        {
            Console.WriteLine($"Заполните поле - ФИО:");
            return Console.ReadLine();
        }
        private byte FieldAge()
        {
            Console.WriteLine($"Заполните поле - Возраст:");
            return byte.Parse(Console.ReadLine());
        }
        private int FieldHeight()
        {
            Console.WriteLine($"Заполните поле - Рост:");
            return int.Parse(Console.ReadLine());
        }
        private DateTime FieldDateOfBirth()
        {
            Console.WriteLine($"Заполните поле - Дата рождения:");
            return DateTime.Parse(Console.ReadLine());
        }
        private string FieldPlaceOfBirth()
        {
            Console.WriteLine($"Заполните поле - Место рождения:");
            return Console.ReadLine();
        }
        private void PrintMenu()
        {
            Console.WriteLine($"{Environment.NewLine}МЕНЮ:");
            for (int i = 0; i < MenuItems.Length; i++)
            {
                Console.WriteLine($"\t{i+1}. {MenuItems[i]}");
            }
        }
    }
}
