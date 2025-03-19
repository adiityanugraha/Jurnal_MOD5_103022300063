using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300063
{
    public class SimpleDataBase<T>
    {
        public List<T> storedData;
        public List<DateTime> inputDate;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDate.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi : {storedData[i]}, yang disimpan pada waktu UTC {inputDate[i].ToUniversalTime()}");
            }
        }
    }
}
