using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace deneme
{
    internal class Program
    {
        [DllImport("Dll3.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Multiply(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());

            int result = Multiply(x, y);

            Console.WriteLine($"Conclusion: {result}");
            Console.ReadKey();
        }
    }
}
