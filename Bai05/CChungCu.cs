using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CChungCu : CBatDongSan
    {
        private int Tang { get; set; }

        public CChungCu() : base()
        {
            Tang = 0;
        }

        public override void Nhap()
        {
            Console.WriteLine("\t---Nhap thong tin chung cu: ");
            base.Nhap();
            Console.Write("Nhap so tang: ");
            int tmp;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out tmp) && tmp >= 0)
                {
                    Tang = tmp;
                    break;
                }
                Console.Write("Gia tri khong hop le. Nhap lai so tang: ");
            }
        }

        public override void Xuat()
        {
            Console.WriteLine("\t---Thong tin chung cu---");
            base.Xuat();
            Console.WriteLine($"So tang: {Tang}");
        }
    }
}
