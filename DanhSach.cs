using System;
using System.Collections.Generic;
using System.Text;

namespace btvn_cau6
{
    class DanhSach
    {
        private int n;
        private QLSinhVien[] DS;

        public void nhap()
        {
            Console.WriteLine(" nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new QLSinhVien[n];
            for (int i = 0; i < n; i++)
            {
                DS[i] = new QLSinhVien();
                DS[i].nhap();
            }
        }
        public void inthongtin()
        {
            if (DS != null && n != 0)
                for (int i = 0; i < n; i++)
                {
                    DS[i].inTT();
                }

        }
        public void sapxep()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(DS[i].Masv, DS[j].Masv, true) >= 0)
                    {
                        QLSinhVien tg = new QLSinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;

                    }
                }
        }

        public void danhsach1()
        {

            for (int i = 0; i < n; i++)
            {
                if (DS[i].diemTB > 8)
                {
                    DS[i].tinhtb();

                }
            }
        }
    }
}