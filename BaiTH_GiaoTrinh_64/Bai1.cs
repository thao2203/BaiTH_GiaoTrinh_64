using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH_GiaoTrinh_64
{
    class Bai1
    {
        static void Main(string[] args)
        {
            //double s = 1, p = 1, x;
            //int n;
            //Console.WriteLine("Nhap n = ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap x = ");
            //x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    p = p * x / i;
            //    s = s + p;
            //}
            //Console.WriteLine("Ket qua:" + s);
            b1();
            Console.ReadKey();
        }

        //Bai1
        public static void b1()
        {
            int n;
            int x;
            double s = 0;
            Console.WriteLine("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap x = ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s += mu(x,i) / giaThua(i);
            }
            Console.WriteLine("Ket qua:" + (s+1));

        }
        private static double giaThua(int n)
        {
            int t = 1;
            for (int i = 1; i <= n; i++) 
            {
                t = t * i;
            }
            return t;
        }
        private static double mu(int x, int n)
        {
            double y = 0;
            y = Math.Pow(x, n);
            return y;
        }
    }
}
