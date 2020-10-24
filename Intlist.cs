using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice5
{
    class Intlist
    {
        List<int> intList = new List<int>();


        public Intlist()
        {
            intList.Add(5);
            intList.Add(1);
            intList.Add(3);
            intList.Add(2);
            intList.Add(8);
        }

        public void setList(int x, int y)
        {
                if (x <= intList.Count+1 & x>0)
                {
                    intList.Insert(x-1, y);
                }
                else
                {
                Console.WriteLine("Nope.");
                }
            }
        

        public void printList()
        {
            foreach(int amount in intList)
            {
                Console.WriteLine("Number: "+amount);
            }
        }
    }
}
