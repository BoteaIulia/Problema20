using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2611
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Afisati fractia m/n in format zecimal cu perioada intre paranteze ");
            Console.Write("\n");
            int m;
            int n;
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fractia in format zecimal este:  ");
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }

        }

    }
}
