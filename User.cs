using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct User
    {
        private long ID;
        private DateTime CreateDate;
        private string UserName;
        private byte Age;
        private int Height;
        private DateTime DateOfBirth;
        private string PlaceOfBirth;
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        /// <param name="Age"></param>
        /// <param name="Height"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="PlaceOfBirth"></param>
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
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        /// <param name="Age"></param>
        /// <param name="Height"></param>
        /// <param name="DateOfBirth"></param>
        public User(long ID, string UserName, byte Age, int Height, DateTime DateOfBirth) :
            this(ID, UserName, Age, Height, DateOfBirth, string.Empty)
        { 
        }
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        /// <param name="Age"></param>
        /// <param name="Height"></param>
        public User(long ID, string UserName, byte Age, int Height) :
            this(ID, UserName, Age, Height, new DateTime(1900,1,1,0,0,0),string.Empty)
        {
        }
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        /// <param name="Age"></param>
        public User(long ID, string UserName, byte Age) :
            this(ID, UserName, Age, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        public User(long ID, string UserName) :
            this(ID, UserName, 0, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="ID"></param>
        public User(long ID) :
        this(ID, "User"+ID, 0, 0, new DateTime(1900, 1, 1, 0, 0, 0), string.Empty)
        {
        }

    }
}
