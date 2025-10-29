namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListBatDongSan list = new ListBatDongSan();
            list.Nhap();
            list.Xuat();

            Console.WriteLine("\t---Tong gia ban tat ca bat dong san: " + list.TongGiaBan() + " VND");
            list.XuatKhuDatDienTichLonHon100m2();
            list.XuatNhaPhoDienTichLonHon60NamXDTu2019();
            list.TimKiem();
        }
    }
}
