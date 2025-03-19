using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300063
{
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T n1, T n2, T n3)
        {
            dynamic nilai1 = (dynamic)n1;
            dynamic nilai2 = (dynamic)n2;
            dynamic nilai3 = (dynamic)n3;

            if (nilai1 > nilai2 && nilai1 > nilai3)
                {
                    Console.WriteLine("Nilai terbesar adalah " + nilai1);
                }
                else if (nilai2 > nilai1 && nilai2 > nilai3)
                {
                    Console.WriteLine("Nilai terbesar adalah " + nilai2);
                }
                else if (nilai3 > nilai1 && nilai3 > nilai2)
                {
                    Console.WriteLine("Nilai terbesar adalah " + nilai3);
                }
            
        }
    }
}
