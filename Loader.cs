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
        private const string Separator="#";
        private string Path;
        /// <summary>
        /// Структура для работы с файлом Пользователей
        /// </summary>
        /// <param name="Path"></param>
        public Loader(string Path)
        {
            this.Path=Path;
        }
    }
}
