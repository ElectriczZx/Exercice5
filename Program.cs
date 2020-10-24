using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int pos;

            Intlist il = new Intlist();

            Console.Write("Value: ");
            value = int.Parse(Console.ReadLine());
            Console.Write("Position: ");
            pos = int.Parse(Console.ReadLine());
            il.setList(pos, value);
            il.printList();
        }
    }
}
