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
        public Loader ObjLoader { get; set; }
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
