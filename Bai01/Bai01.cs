namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;

            Console.Write("Nhap thang (1 -> 12): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out thang) && thang >= 1 && thang <= 12)
                    break;

                Console.Write("Gia tri khong hop le. Nhap lai thang: ");
            }

            Console.Write("Nhap nam (>= 1): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out nam) && nam >= 1)
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai nam: ");
            }

            InLich(thang, nam);

        }

        static bool KTNamNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                return true;
            return false;
        }

        static int NgayTrongThang(int thang, int nam)
        {
            int[] arr = { 0, 31, 28, 31, 30, 31, 30, 31, 30, 31, 31, 30, 31 };
            if (thang == 2 && KTNamNhuan(nam))
            {
                arr[2] = 29;
            }
            return arr[thang];
        }

        static void InLich(int thang, int nam)
        {
            DateTime FirstDay = new DateTime(nam, thang, 1); //ngay dau tien trong thang
            int StartDay = (int)FirstDay.DayOfWeek; //thu cua ngay dau tien trong thang

            Console.WriteLine($"Month: {thang}/{nam}");


            Console.Write("\nSun\tMon\tTue\tWed\tThu\tFri\tSat");
            Console.WriteLine();

            for (int i = 0; i < StartDay; i++)
                Console.Write("\t");

            for(int ngay = 1; ngay <= NgayTrongThang(thang, nam); ngay++)
            {
                Console.Write($"{ngay}\t");

                if((ngay+StartDay)%7==0) 
                    Console.WriteLine();
            }


        }
    }
}
