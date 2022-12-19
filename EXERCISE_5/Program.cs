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
            public string name;
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
                string nm;
                Console.WriteLine("Enter a number: ");
                no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                nm = Console.ReadLine();
                Node newnode = new Node();
                newnode.number = no;
                newnode.name = nm;
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
                    return;
                }

            }
            public bool ListEmpty()
            {
                if (Lisa == null)
                    return true;
                else
                    return false;
            }

            public void delNumb()
            {
                Node curr;
                curr = Lisa;
                Console.WriteLine("The deleted number is: " + Lisa);
                Lisa = Lisa.next;
            }

            public void displayNumb()
            {
                if (ListEmpty())
                {
                    Console.WriteLine("List Empty. ");
                }
                else
                {
                    Console.WriteLine("the number is the list are: ");
                    Node currNode;
                    for(currNode = Lisa; currNode != null; currNode = currNode.next)
                        Console.WriteLine(" -" + currNode.number);
                    Console.WriteLine();
                }
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Queue q = new Queue();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("a. insert number");
                        Console.WriteLine("b. delete number");
                        Console.WriteLine("c. display");
                        Console.WriteLine("d. Exit");
                        Console.WriteLine(" choice a-d : ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case 'a':
                                {
                                    q.addNumb();
                                }
                                break;
                            case 'b':
                                {
                                    if (q.ListEmpty())
                                    {
                                        Console.WriteLine("List empty. ");
                                        break;
                                    }
                                    q.delNumb();
                                }
                                break;
                            case 'c':
                                {
                                    q.displayNumb();
                                }
                                break;
                            case'd':
                                return;
                            default:
                                {
                                    Console.WriteLine("\n Invalid Option ");
                                    break;
                                }
                        }
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("\n Check Again! . ");
                    }
                }
            }
        }
    }
}
