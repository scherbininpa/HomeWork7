using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct Loader
    {
        User[] ArrUsers;
        /// <summary>
        /// разделитель полей в файле
        /// </summary>
        private const string Separator = "#";
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Количество пользователей
        /// </summary>
        int TotalUser;
        /// <summary>
        /// Структура для работы с файлом Пользователей
        /// </summary>
        /// <param name="Path">Путь к файлу</param>
        public Loader(string Path)
        {
            this.ArrUsers = new User[4];
            if (new FileInfo(Path).Exists)
            {
                this.Path = Path;
                TotalUser = 0;
            } 
            else
            {
                this.Path = string.Empty;
                TotalUser = 0;
                Print($"Файл {Path} не найден!");
            }
            

        }

        private void ReDim()
        { 
            Array.Resize(ref ArrUsers, TotalUser*2);
        }
        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        public async void Load()
        {
            string line;
            string[] UserData;
            
            using (StreamReader SR = new StreamReader(this.Path))
            {
                while ((line = await SR.ReadLineAsync()) != null)
                {
                    UserData = line.Split(Separator);
                    if (TotalUser >= ArrUsers.Length) ReDim();
                    User user = new User(Convert.ToInt32(UserData[0]),
                                         Convert.ToDateTime(UserData[1]),
                                         UserData[2],
                                         Convert.ToByte(UserData[3]),
                                         Convert.ToInt16(UserData[4]),
                                         Convert.ToDateTime(UserData[5]),
                                         UserData[6]);
                    ArrUsers[TotalUser] = user;
                    ++TotalUser;
                }
            }
        }
        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        public async void Save()
        {
            using (StreamWriter SW = new StreamWriter(this.Path, false))
            {
                for (int i = 0; i < TotalUser; i++)
                {
                    await SW.WriteLineAsync(ArrUsers[i].ToString(Separator));
                }
            }
        
        }
        /// <summary>
        /// Добавить пользователя
        /// </summary>
        /// <param name="UserName">ФИО</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        public void CreateUser(string UserName, DateTime DateOfBirth, string PlaceOfBirth)
        {

        }
        /// <summary>
        /// Добавить пользователя
        /// </summary>
        /// <param name="UserName">ФИО</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        public void CreateUser(string UserName, DateTime DateOfBirth)
        {

        }
        /// <summary>
        /// Добавить пользователя
        /// </summary>
        /// <param name="UserName">ФИО</param>
        public void CreateUser(string UserName)
        {

        }
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="ID">Идентификатор пользователя</param>
        /// <returns></returns>
        public bool DeleteUser(long ID)
        {
            return true;
        }
        /// <summary>
        /// Редактирование ФИО пользователя и/или места рождения
        /// </summary>
        /// <param name="ID">Уникальный идентификатор пользователя(используется для указания пользователя)</param>
        /// <param name="UserName">Новое значение ФИО</param>
        /// /// <param name="PlaceOfBirth">Место рождения пользователя</param>
        public void EditUser(long ID, string UserName, string PlaceOfBirth="")
        { }
        /// <summary>
        /// Редактирование даты рождения пользователя
        /// </summary>
        /// <param name="ID">Уникальный идентификатор пользователя(используется для указания пользователя)</param>
        /// <param name="DateOfBirth">Новое значение даты рождения</param>
        public void EditUser(long ID, DateTime DateOfBirth)
        { }
        /// <summary>
        /// Вывод на экран записи пользователя
        /// </summary>
        /// <param name="ID">Уникальный идентификатор пользователя</param>
        public void Print(long ID)
        { 
        }
        /// <summary>
        /// Вывод на экран сообщения
        /// </summary>
        /// <param name="Message">Сообщение для вывода</param>
        public void Print(string Message)
        {
            Console.WriteLine(Message);
        }
        public void Sort()
        {
            
        }
    }
}
