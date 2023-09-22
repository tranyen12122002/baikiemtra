using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace baikiemtra
{
    internal class Program
    {
        private static object convert;
        static void Main(string[] args)
        {
            int n,max=0, dem=0;
            Console.WriteLine("Nhap vao so phan tu cua mang: ");
            n= Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu: "+(i+1)+": ");
                a[i] = Convert.ToInt32(Console.ReadLine()) ;
            }
            for (int i = 0;i< n; i++)
            {
                if (a[i]> max)
                { 
                    max = a[i];
                    dem = i + 1;
                }
            }
            Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
            Console.WriteLine("Vi tri cua so lon nhat trong mang la: "+dem);
            Console.ReadKey();
                }
    }
}