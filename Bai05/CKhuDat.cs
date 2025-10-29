using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CKhuDat : CBatDongSan
    {
        public override void Nhap()
        {
            Console.WriteLine("\t---Nhap thong tin khu dat: ");
            base.Nhap();
        }

        public override void Xuat()
        {
            Console.WriteLine("\t---Thong tin khu dat---");
            base.Xuat();
        }      
    }
}
