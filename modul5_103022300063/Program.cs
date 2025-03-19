using System;

using modul5_103022300063;

public class Program
{
    public static void Main()
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.DapatkanNilaiTerbesar<double>(30,00,63);

        SimpleDataBase<double> dataBase = new SimpleDataBase<double>();
        dataBase.addNewData(30);
        dataBase.addNewData(00);
        dataBase.addNewData(63);
        dataBase.PrintAllData();
    }
}
