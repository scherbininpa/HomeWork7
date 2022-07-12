using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct Loader
    {
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
        public long TotalUser { get; }
        /// <summary>
        /// Структура для работы с файлом Пользователей
        /// </summary>
        /// <param name="Path">Путь к файлу</param>
        public Loader(string Path)
        {
            this.Path = Path;
            TotalUser = 0;
        }
        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        public void Load()
        { }
        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        public void Save()
        { }
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
        public void EditUser(long ID, string UserName="", string PlaceOfBirth="")
        { }
        /// <summary>
        /// Редактирование даты рождения пользователя
        /// </summary>
        /// <param name="ID">Уникальный идентификатор пользователя(используется для указания пользователя)</param>
        /// <param name="DateOfBirth">Новое значение даты рождения</param>
        public void EditUser(long ID, DateTime DateOfBirth)
        { }

    }
}
