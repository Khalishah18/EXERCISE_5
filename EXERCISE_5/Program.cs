using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_5
{
    class Program
    {
        class Node
        {
            public int number;
            public Node next;
        }

        class Queue
        {
            Node Lisa, Salsa;

            public Queue()
            {
                Lisa = null;
                Salsa = null;
            }
            
            public void addNumb()
            {
                int no;
                Console.WriteLine("Enter a number: ");
                no = Convert.ToInt32(Console.ReadLine());
                Node newnode = new Node();
                newnode.number = no;
                if(Lisa == null || (no <= Lisa.number))
                {
                    if ((Lisa != null) && (no == Lisa.number))
                    {
                        Console.WriteLine("Duplicate Number is not allowed");
                        return;
                    }

                    newnode.next = Lisa;
                    newnode.next = Salsa;
                    Lisa = Salsa = newnode;
                    return;
                }

                while ((Lisa != null) && (no <= Lisa.number)) ;
                {
                    if (no == Lisa.number)
                    {
                        Console.WriteLine("Duplicate Number is not allow ");
                        return;
                    }
                    Lisa.next = newnode;
                    newnode = Lisa;

                }

            }
            public bool ListEmpty()
            {
                if (Lisa == null)
                    return true;
                else
                    return false;
            }

            public bool delNumb()
            {
                Node curr;
                curr = Lisa;
                Lisa = Lisa.next;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
