using System;
using System.Collections.Generic;
using System.Text;

namespace btvn_cau6
{
    class QLSinhVien
    {
        private string maSV;
        private string hoten;
        private int namsinh;
        private double diemlt;
        private double diemCSDL;
        public double diemTB;

        public string Masv
        {
            get
            {
                return this.maSV;
            }
            set
            {
                this.maSV = value;
            }
        }

        public QLSinhVien()
        {
            maSV = "";
            hoten = "";
            namsinh = 1998;
            diemlt = diemCSDL = diemTB = 0;
        }
        public QLSinhVien(string maSV, string hoten, int namsinh, double diemlt, double diemCSDL)
        {
            this.maSV = maSV;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.diemlt = diemlt;
            this.diemCSDL = diemCSDL;
            // this.diemTB=(diemlt+diemCSDL)*0.5;
        }
        public double TB()
        {
            diemTB = (diemlt + diemCSDL) * 0.5;
            return diemTB;
        }
        public void tinhtb()
        {
            if (diemTB > 8)
            {
                Console.WriteLine(" thong tin sinh \n maSV: {0} \t ho ten: {1} \t nam sinh: {2} "
                         + "\t điem LT: {3} \t điem CSDL {4}", maSV, hoten, namsinh, diemlt, diemCSDL, TB());
            }
        }
        public void nhap()
        {
            Console.WriteLine(" hay nhap ma sinh vien");
            maSV = Console.ReadLine();
            Console.WriteLine(" hay nhap ho ten sinh vien");
            hoten = Console.ReadLine();
            Console.WriteLine(" hay nhap nam sinh");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap diem  lap trinh ");
            diemlt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hay nhap diem CSDL ");
            diemCSDL = Convert.ToDouble(Console.ReadLine());
        }
        public void inTT()
        {
            Console.WriteLine(" thong tin sinh \n maSV: {0} \t ho ten: {1} \t nam sinh: {2} "
                         + "\t điem LT: {3} \t điem CSDL {4}\t diem TB: ", maSV, hoten, namsinh, diemlt, diemCSDL, TB());

        }
    }
}