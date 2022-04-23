using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] result = new byte[4];
            for(int i = 0; i < 4; i++)
            {
               result[i] = Convert.ToByte(Console.ReadLine());
                
            }
            result = Reserve(result);           
            Console.WriteLine($"{result[0]}, {result[1]}, {result[2]}, {result[3]} ");
            Console.ReadLine();
        }
        public static byte[] Reserve(byte[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int tmp = (int)a[i];               
                tmp = ((tmp & 0x55) << 1) | ((tmp >> 1) & 0x55);
                tmp = ((tmp & 0x33) << 2) | ((tmp >> 2) & 0x33);
                tmp = ((tmp & 0x0F) << 4) | ((tmp >> 4) & 0x0F);
                a[i] = (byte)tmp;
            }
                return a;
        }


    }
}
