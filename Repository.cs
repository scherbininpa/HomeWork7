using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork7;
namespace HomeWork7
{
    class Repository
    {
        private string _path;
        private int _totalUser;
        private string _separator = "#";
        public Repository(string Path)
        {
            this._path = Path;
            this._totalUser = -1;
        }
        private void ReDim(worker[] arr)
        {
            Array.Resize(ref arr, this._totalUser);
        }
        public worker[] GetAllWorkers()
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров

            string line;
            string[] UserData;
            worker[] arrWorker=new worker[_totalUser];
            worker tmpWorker = new worker();
            using (StreamReader SR = new StreamReader(this._path))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    ++this._totalUser;
                    UserData = line.Split(_separator);
                    if (_totalUser >= arrWorker.Length) ReDim(arrWorker);

                    tmpWorker.Id = Convert.ToInt32(UserData[0]);
                    tmpWorker.DateCreate = Convert.ToDateTime(UserData[1]);
                    tmpWorker.FIO= UserData[2];
                    tmpWorker.Age = Convert.ToInt32(UserData[3]);
                    tmpWorker.Height= Convert.ToInt32(UserData[4]);
                    tmpWorker.DateOfBirth= Convert.ToDateTime(UserData[5]);
                    tmpWorker.PlaceOfBirth= UserData[6];
                    arrWorker[this._totalUser] = tmpWorker;
                }
            }
            return arrWorker;
        }

        public worker GetWorkerById(int id)
        {
            worker returnWorker = new worker();
            worker[] arrWorker = GetAllWorkers();
            foreach (worker _worker in arrWorker)
            {
                if (_worker.Id == id) {
                    returnWorker = _worker;
                    break;
                }
            }

            return returnWorker;
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
        }

        public void DeleteWorker(int id)
        {
            worker[] arrWorker = GetAllWorkers();
            for (int i = 0; i < arrWorker.Length; i++)
            {
                if (arrWorker[i].Id==id)
                {
                    Array.Clear(arrWorker, i, 1);
                    break;
                }
            }

            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }

        private void SaveData(worker[] _workers)
        {
            using (StreamWriter SW = new StreamWriter(this._path, false))
            {
                foreach (var _worker in _workers)
                {
                    SW.WriteLine(_worker.LineToWrite(_separator));
                }
            }
        }
        public void AddWorker(worker worker)
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
        }

        public worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
        }
    }
}
