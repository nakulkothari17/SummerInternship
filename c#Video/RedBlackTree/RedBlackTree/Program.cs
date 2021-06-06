using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBlackTree<int> rbtre = new RedBlackTree<int>();   

            rbtre.Add(20);
            rbtre.Add(10);
            rbtre.Add(30);
            rbtre.Add(5);
            rbtre.Add(35);            
            rbtre.Add(25);
            rbtre.Add(27);
            rbtre.Remove(30);
            rbtre.Remove(20);

            Console.WriteLine("hello");
            Console.ReadLine();
        }
    }
}