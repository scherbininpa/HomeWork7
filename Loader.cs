﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct Loader
    {
        private User[] ArrUsers;
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
        private int TotalUser;
        /// <summary>
        /// Структура для работы с файлом Пользователей
        /// </summary>
        /// <param name="Path">Путь к файлу</param>
        public Loader(string Path)
        {

            if (new FileInfo(Path).Exists)
            {
                this.Path = Path;
                TotalUser = 0;
                ArrUsers = new User[TotalUser];
                Load();
            } 
            else
            {
                this.Path = string.Empty;
                TotalUser = 0;
                throw new ArgumentException("Файл не найден.");
            }
            

        }
        private void ReDim()
        { 
            Array.Resize(ref ArrUsers, TotalUser);
        }
        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        private void Load()
        {
            string line;
            string[] UserData;
            using (StreamReader SR = new StreamReader(this.Path))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    ++TotalUser;
                    UserData = line.Split(Separator);
                    if (TotalUser >= ArrUsers.Length) ReDim();
                    ArrUsers[TotalUser-1] = new User(Convert.ToInt32(UserData[0]),
                                         Convert.ToDateTime(UserData[1]),
                                         UserData[2],
                                         Convert.ToByte(UserData[3]),
                                         Convert.ToInt16(UserData[4]),
                                         Convert.ToDateTime(UserData[5]),
                                         UserData[6]);
                }
            }
        }
        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        public void Save()
        {
            using (StreamWriter SW = new StreamWriter(this.Path, false))
            {
                for (int i = 0; i <= TotalUser; i++)
                {
                    SW.WriteLine(ArrUsers[i].ToString(Separator));
                }
            }
        
        }
        /// <summary>
        /// Добавить пользователя
        /// </summary>
        /// <param name="UserName">ФИО</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        public void AddUser(string UserName, byte Age, int Height, DateTime DateOfBirth, string PlaceOfBirth)
        {
            this.TotalUser++;
            ReDim();
           this.ArrUsers[TotalUser-1] = new User(TotalUser,DateTime.Now,UserName,Age,Height,DateOfBirth,PlaceOfBirth);
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
        public void EditUser(long ID, string UserName, byte Age, int Height, DateTime DateOfBirth,string PlaceOfBirth)
        {
            if (ID == long.MinValue)
            {
                Print("Пользователь не найден");
            }
            else {
                this.ArrUsers[ID].UserName = String.IsNullOrEmpty(UserName) ? this.ArrUsers[ID].UserName : UserName;
                this.ArrUsers[ID].Age = (Age == byte.MinValue) ? this.ArrUsers[ID].Age : Age;
                this.ArrUsers[ID].Height = (Height == int.MinValue) ? this.ArrUsers[ID].Height : Height;
                this.ArrUsers[ID].DateOfBirth = (DateOfBirth == DateTime.MinValue) ? this.ArrUsers[ID].DateOfBirth : DateOfBirth;
                this.ArrUsers[ID].PlaceOfBirth = String.IsNullOrEmpty(PlaceOfBirth) ? this.ArrUsers[ID].PlaceOfBirth : PlaceOfBirth;
            }
        }
        public bool CheckIDUser(long ID)
        {
            if (ID < 0 || ID > this.TotalUser)
            {
                Print("Пользователь не найден");
                return false;
            }
            else { return true; }
        }
        /// <summary>
        /// Вывод на экран записи пользователя
        /// </summary>
        /// <param name="ID">Уникальный идентификатор пользователя</param>
        public void Print(long ID)
        {
            if (ID < 0 || ID > this.TotalUser){ 
                Console.WriteLine("ID не найден."); 
            }
            else
            {
                Console.WriteLine($"\tID\tДата и время добавления\tФИО\t\t\t\tВозраст\tРост\tДата рождения\tМесто рождения");
                Console.WriteLine($"\t{ArrUsers[ID].ID:00}\t{ArrUsers[ID].CreateDate}\t{ArrUsers[ID].UserName,-25}\t{ArrUsers[ID].Age}" +
                                $"\t{ArrUsers[ID].Height}\t{ArrUsers[ID].DateOfBirth}\t{ArrUsers[ID].PlaceOfBirth}");
            }
        }
        /// <summary>
        /// Вывод на экран записи всех пользователя
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"\tID\tДата и время добавления\tФИО\t\t\t\tВозраст\tРост\tДата рождения\tМесто рождения");
            foreach (User user in ArrUsers)
            {
                Console.WriteLine($"\t{user.ID:00}\t{user.CreateDate}\t{user.UserName,-25}\t{user.Age}\t{user.Height}\t{user.DateOfBirth}\t{user.PlaceOfBirth}");
            }
        }
        /// <summary>
        /// Вывод на экран сообщения
        /// </summary>
        /// <param name="Message">Сообщение для вывода</param>
        public void Print(string Message)
        {
            Console.WriteLine(Message);
        }
        public void Sort(bool Ask = true )
        {
            //User[] user = { ArrUsers[1], ArrUsers[2], ArrUsers[3] }; 
            Array.Sort(ArrUsers);
            if (!Ask)  Array.Reverse(ArrUsers);
        }
    }
}
