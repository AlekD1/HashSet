using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._05_HashSet
{
    class Program
    {
        static void ShowColl(HashSet<int> ss, string s)
        {
            Console.WriteLine(s);
            foreach (int ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
        static void Main()
        {
            HashSet<int> A = new HashSet<int>();
            Random ran = new Random();
            for (int i = 0; i < 14; i++)
                A.Add(ran.Next(1, 16));
            ShowColl(A, "Случайное множество А: ");
            int x = ran.Next(1, 21);
            Console.WriteLine("Случайное число из диапазона [0,21] = {0}",x);
            if (A.Contains(x)) Console.WriteLine("{0} входит в множетсво А", x);
            Console.WriteLine("Кардинальное число множетсва А равно = {0}", A.Count);
            Console.WriteLine("Кардинальное число булеана множетсва А равно = {0}", Math.Pow(2, A.Count));
            Console.ReadLine();
        }
    }
}
