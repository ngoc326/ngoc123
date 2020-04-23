using System;

namespace btvn_cau6
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSinhVien sv1 = new QLSinhVien();
            sv1.nhap();
            sv1.inTT();
            DanhSach ds1 = new DanhSach();
            ds1.nhap();
            ds1.inthongtin();
            Console.WriteLine(" sap xep la\n");
            ds1.sapxep();
            ds1.inthongtin();
            Console.WriteLine(" diem >8  la\n");
            ds1.danhsach1();
            Console.ReadLine();
        }
    }
}