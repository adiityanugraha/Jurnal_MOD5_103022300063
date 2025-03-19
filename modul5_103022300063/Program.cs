using System;

using modul5_103022300063;

public class Program
{
    public static void Main()
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.DapatkanNilaiTerbesar<double>(10,20,30);

        SimpleDataBase<double> dataBase = new SimpleDataBase<double>();
        dataBase.addNewData(10);
        dataBase.addNewData(20);
        dataBase.addNewData(30);
        dataBase.PrintAllData();
    }
}
