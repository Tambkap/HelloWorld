using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Khai báo 2 biến kiểu int là a và b;
            int a = 5; // Giá trị mặc định, Khi khởi tạo lên đã có.
            int b = 5;
            int result = a + b;

            Console.WriteLine("Enter Number a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kết quả của phép cộng là :" + PlusNumber(a, b));
            Console.Write("dddddddddddddddd");
            Console.ReadLine();

            // Công cụ lập trình visual Studio
        }

        /// <summary>
        /// Hàm này là hàm cộng 2 số
        /// </summary>
        /// <returns></returns>
        public static int PlusNumber(int a, int b)
        {
            return a + b + 5;
        }

        /// <summary>
        /// Something 
        /// </summary>
        /// <returns></returns>
        public static int Something()
        {
            return 555555;
        }
    }
}
