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
        public Loader ObjLoader { get; }
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
            ObjLoader.Load();
            ObjLoader.Print();
        }

        public void PrintMenu()
        {
            Console.WriteLine($"{Environment.NewLine}МЕНЮ:");
            for (int i = 0; i < MenuItems.Length; i++)
            {
                Console.WriteLine($"{i+1}. {MenuItems[i]}");
            }
        }
    }
}
