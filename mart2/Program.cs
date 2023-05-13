using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_2__task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            string name, gender = null;
            byte n;
            //ArrayList list = new ArrayList();
            Queue<string> SeniorsWaiting = new Queue<string>();
            Queue<string> NormalWaiting = new Queue<string>();
            Queue<string> cashier3 = new Queue<string>();
            Queue<string> cashier2 = new Queue<string>();
            Queue<string> cashier1 = new Queue<string>();
            do
            {


                Console.WriteLine("\n\n===========================================================\n");
                Console.WriteLine("1: Entering data");
                Console.WriteLine("2: Entertain Customers");
                Console.WriteLine("3: Exit");
                Console.Write("\nEnter the Number:");
                n = byte.Parse(Console.ReadLine());

                switch (n)
                    {
                        case 1:
                        Console.Clear();
                    if ((SeniorsWaiting.Count + NormalWaiting.Count) < 20)
                    {
                        Console.WriteLine("\n**** Customer Data *****\n");
                        for (int i = 0; i < 3; i++)
                        {


                            try
                            {

                                Console.Write("Enter Your Name: ");
                                name = Console.ReadLine();
                                Console.Write("\nEnter Your Age: ");
                                Age = int.Parse(Console.ReadLine());
                                Console.Write("\nEnter Your Gender: ");
                                gender = Console.ReadLine().ToLower();
                                //  list.Add(name);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n\nEnter the valid data ");
                                continue;
                            }

                            if (Age > 60 || gender.Equals("female"))
                            {
                                SeniorsWaiting.Enqueue(name);
                                Console.WriteLine("\n------Data Entered in Seniors Waiting\n");
                            }
                            else
                            {
                                NormalWaiting.Enqueue(name);
                                Console.WriteLine("\n------Data Entered in Normal Waiting\n");
                            }




                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nWaiting Queues are Full");
                    }

                    if (NormalWaiting.Count != 0)
                    {
                        cashier1.Enqueue(NormalWaiting.Dequeue());
                    }
                    if (NormalWaiting.Count != 0)
                    {
                        cashier2.Enqueue(NormalWaiting.Dequeue());
                    }
                    if (SeniorsWaiting.Count != 0)
                    {
                        cashier3.Enqueue(SeniorsWaiting.Dequeue());
                    }



                    break;
                        
                    
                    
                    
                    
                    case 2:
                        Console.Clear();

                    if (cashier1.Count == 0)
                    {
                        Console.WriteLine("Cashier 1 is Empty....!");

                    }
                    else
                    {
                        Console.WriteLine("Cashier 1 Customer: " + cashier1.Dequeue());
                    }

                    if (cashier2.Count == 0)
                    {
                        Console.WriteLine("Cashier 2 is Empty....!");

                    }
                    else
                    {
                        Console.WriteLine("Cashier 2 Customer: " + cashier2.Dequeue());

                    }
                    if (cashier3.Count == 0)
                    {
                        Console.WriteLine("Cashier 3 is Empty....!");

                    }
                    else
                    {
                        Console.WriteLine("Cashier 3 Customer: " + cashier3.Dequeue());

                    }


                    if (NormalWaiting.Count != 0)
                    {
                        cashier1.Enqueue(NormalWaiting.Dequeue());
                    }
                    if (NormalWaiting.Count != 0)
                    {
                        cashier2.Enqueue(NormalWaiting.Dequeue());
                    }
                    if (SeniorsWaiting.Count != 0)
                    {
                        cashier3.Enqueue(SeniorsWaiting.Dequeue());
                    }

                    break;
                    case 3:
                        break;
                    default:
                            {
                        Console.WriteLine("\n\nPlease Select Valid Option");
                    }
                    break;

                }

            } while (n != 3);

        }
    }
}