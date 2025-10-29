using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class CPhanSo
    {
        private int Tu { get; set; }
        private int Mau { get; set; }

        public CPhanSo(int tu = 0, int mau = 1)
        {
            Tu = tu;
            Mau = mau;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            int tu;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out tu))
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai tu so: ");
            }
            Tu = tu;

            Console.Write("Nhap mau so: ");
            int mau;
            while (true)
            {
                bool check = int.TryParse(Console.ReadLine(), out mau);
                if (check && mau!=0)
                {
                    break;
                }
                
                Console.Write("Gia tri khong hop le. Nhap lai mau so: ");

            }
            Mau = mau;
        }

        public void Xuat()
        {
            if (Mau == 1)
                Console.Write(Tu);
            else if (Tu == 0)
                Console.Write(0);
            else if ((Tu < 0 && Mau < 0) || (Tu > 0 && Mau < 0))
                Console.Write(-Tu + "/" + -Mau);
            else Console.Write(Tu + "/" + Mau);
        }
        
        public CPhanSo RutGon()
        {
            int a = Math.Abs(Tu);
            int b = Math.Abs(Mau);
            while(b!=0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            Tu = Tu / a;
            Mau = Mau / a;
            return this;
        }

        public bool SoSanhLonHon(CPhanSo x) //return true neu this > x
        {
            if ((float)this.Tu * x.Mau > (float)this.Mau * x.Tu)
                return true;
            return false;
        }

        public static CPhanSo operator + (CPhanSo a, CPhanSo b)
        {
            CPhanSo res = new CPhanSo();
            res.Tu = a.Tu * b.Mau + a.Mau * b.Tu;
            res.Mau = a.Mau * b.Mau;
            return res.RutGon();
        }

        public static CPhanSo operator - (CPhanSo a, CPhanSo b)
        {
            CPhanSo res = new CPhanSo();
            res.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
            res.Mau = a.Mau * b.Mau;
            return res.RutGon();
        }

        public static CPhanSo operator * (CPhanSo a, CPhanSo b)
        {
            CPhanSo res = new CPhanSo();
            res.Tu = a.Tu * b.Tu;
            res.Mau = a.Mau * b.Mau;
            return res.RutGon();
        }

        public static CPhanSo operator / (CPhanSo a, CPhanSo b)
        {
            CPhanSo res = new CPhanSo();
            res.Tu = a.Tu * b.Mau;
            res.Mau = a.Mau * b.Tu;
            return res.RutGon();
        }
    }


}
