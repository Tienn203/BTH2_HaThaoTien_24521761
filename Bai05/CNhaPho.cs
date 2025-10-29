using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CNhaPho : CBatDongSan
    {
        private int NamXayDung { get; set; }
        private int SoTang { get; set; }
        
        public CNhaPho() : base()
        {
            NamXayDung = 0;
            SoTang = 0;
        }

        public override void Nhap()
        {
            Console.WriteLine("\t---Nhap thong tin nha pho: ");
            base.Nhap();

            int tmp;
            Console.Write("Nhap nam xay dung: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out tmp) && tmp > 0)
                {
                    NamXayDung = tmp;
                    break;
                }
                Console.Write("Gia tri khong hop le. Nhap lai nam xay dung: ");
            }

            Console.Write("Nhap so tang: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out tmp) && tmp >= 0)
                {
                    SoTang = tmp;
                    break;
                }
                Console.Write("Gia tri khong hop le. Nhap lai so tang: ");
            }
        }

        public override void Xuat()
        {
            Console.WriteLine("\t---Thong tin nha pho---");
            base.Xuat();
            Console.WriteLine($"Nam xay dung: {NamXayDung}");
            Console.WriteLine($"So tang: {SoTang}");
        }

        public int getNamXayDung()
        {
            return NamXayDung;
        }
    }
}
