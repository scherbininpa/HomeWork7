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
            //ObjLoader.Print();
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
                    PrintDescriptionUser();
                    return true;
                    break;
                case '3':
                    ChangeUserDescription();
                    return true;
                    break;
                case '4':
                    ObjLoader.Sort(true);
                    return true;
                    break;
                case '5':
                    ObjLoader.Sort(false);
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
        private void ChangeUserDescription()
        {
            Console.WriteLine("Укажите ID пользователя для редактивования");
            long ID = FieldID();
            if (ID != long.MinValue) 
                ObjLoader.EditUser(ID, FieldUserName(), FieldAge(), FieldHeight(), FieldDateOfBirth(), FieldPlaceOfBirth());
        }
        private void PrintDescriptionUser()
        {
            Console.WriteLine("[1] - вывести все записи \n[2] - вывести указанную запись");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    ObjLoader.Print();
                    break;
                case '2':
                    Console.WriteLine("Укажите ID записи для вывода");
                    ObjLoader.Print(int.Parse(Console.ReadLine()) - 1);
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}Пункт меню не найден!");
                    break;
            }
            Console.WriteLine(Environment.NewLine);
        }
        private long FieldID()
        {
            Console.WriteLine($"Укажите ID пользователя");
            long ID = long.Parse(Console.ReadLine())-1;
            return ObjLoader.CheckIDUser(ID)? ID: long.MinValue;
        }
        private string FieldUserName()
        {
            Console.WriteLine($"Заполните поле - ФИО:");
            string UserName = Console.ReadLine();
            return string.IsNullOrEmpty(UserName) ? String.Empty: UserName;
        }
        private byte FieldAge()
        {
            Console.WriteLine($"Заполните поле - Возраст:");
            string Age = Console.ReadLine();
            return string.IsNullOrEmpty(Age) ? byte.MinValue : byte.Parse(Age);
        }
        private int FieldHeight()
        {
            Console.WriteLine($"Заполните поле - Рост:");
            string Height = Console.ReadLine();
            return string.IsNullOrEmpty(Height) ? int.MinValue : int.Parse(Height);
        }
        private DateTime FieldDateOfBirth()
        {
            Console.WriteLine($"Заполните поле - Дата рождения:");
            string DateOfBirth = Console.ReadLine();
            return string.IsNullOrEmpty(DateOfBirth) ? DateTime.MinValue : DateTime.Parse(DateOfBirth);
        }
        private string FieldPlaceOfBirth()
        {
            Console.WriteLine($"Заполните поле - Место рождения:");
            string PlaceOfBirth = Console.ReadLine();
            return string.IsNullOrEmpty(PlaceOfBirth) ? String.Empty : PlaceOfBirth;
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
