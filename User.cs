using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        public long ID { get; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        /// <param name="UserName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        public User(long ID,string UserName, byte Age, int Height, DateTime DateOfBirth, string PlaceOfBirth)
        { 
            this.ID = ID;
            this.CreateDate=new DateTime();
            this.UserName = UserName;
            this.Age = Age;
            this.Height = Height;   
            this.DateOfBirth = DateOfBirth;
            this.PlaceOfBirth = PlaceOfBirth;
        }
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        /// <param name="UserName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        public User(long ID, string UserName, byte Age, int Height, DateTime DateOfBirth) :
            this(ID, UserName, Age, Height, DateOfBirth, string.Empty)
        { 
        }
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        /// <param name="UserName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        public User(long ID, string UserName, byte Age, int Height) :
            this(ID, UserName, Age, Height, new DateTime(1900,1,1,0,0,0),string.Empty)
        {
        }
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        /// <param name="UserName">ФИО</param>
        /// <param name="Age">Возраст</param>
        public User(long ID, string UserName, byte Age) :
            this(ID, UserName, Age, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        /// <param name="UserName">ФИО</param>
        public User(long ID, string UserName) :
            this(ID, UserName, 0, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="ID">уникальный идентификатор</param>
        public User(long ID) :
            this(ID, "User"+ID, 0, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }

    }
}
