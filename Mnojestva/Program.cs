using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnojestva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> A = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            List<int> B = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            //Obedinenie
            List<int> ints = A.Union(B).ToList();
            Console.WriteLine("Obedinenie:");
            ints.ForEach(u => Console.WriteLine(u + " "));
            //Sechenie
            List<int> Section = new List<int>();
            Section = A.Intersect(B).ToList();
            Console.WriteLine("Sechenie:");
            Section.ForEach(u => Console.WriteLine(u + " "));
            //Razlika
            List<int> Difference = new List<int>();
            Difference = A.Except(B).ToList();
            Console.WriteLine("Razlika:");
            Difference.ForEach(u => Console.WriteLine(u + " "));

            Console.ReadKey();
        }
    }
}
