using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct User:IComparable
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
        /// <param name="CreateDate">дата создания</param>
        /// <param name="UserName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        public User(long ID,DateTime CreateDate,string UserName, byte Age, int Height, DateTime DateOfBirth, string PlaceOfBirth)
        { 
            this.ID = ID;
            this.CreateDate= CreateDate;
            this.UserName = UserName;
            this.Age = Age;
            this.Height = Height;   
            this.DateOfBirth = DateOfBirth;
            this.PlaceOfBirth = PlaceOfBirth;
        }
        public string ToString(string Separator)
        {
            return string.Join(Separator,this.ID,
                                        this.CreateDate,
                                        this.UserName,
                                        this.Age,
                                        this.Height,
                                        this.DateOfBirth,
                                        this.PlaceOfBirth);
        }
        public int CompareTo(object? o)
        {
            if (o is User user) return DateOfBirth.CompareTo(user.DateOfBirth);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
