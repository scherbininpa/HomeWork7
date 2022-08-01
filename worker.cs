using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    struct worker
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public string LineToWrite(string separator)
        {
            return string.Join(separator,
                                Id,
                                DateCreate,
                                FIO,
                                Age,
                                Height,
                                DateOfBirth,
                                PlaceOfBirth);
        }
    }

}
