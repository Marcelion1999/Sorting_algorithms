using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_14_Sorting
{
    class Program
    {
        static void Bubble_sort()
        {
            for (int i = Array.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int a = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = a;

                    }
                }
            }
        }
        static void Max_sorting()
        {
            int max, a;
            for (int x = 0; x < Array.Length; x++)
            {
                for (int i = Array.Length - 1; i > 0; i--)
                {
                    max = i;
                    for (int j = 0; j <= i; j++)
                    {
                        if (Array[j] > Array[max])
                        {
                            max = j;
                        }
                    }
                    a = Array[i];
                    Array[i] = Array[max];
                    Array[max] = a;
                }
            }
            
        }
        static void Min_sorting()
        {
            int a, min;
            for (int x = 0; x < Array.Length; x++)
            {
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < Array.Length; j++)
                    {
                        if (Array[i] < Array[j])
                        {
                            min = j;
                        }
                    }
                    a = Array[min];
                    Array[min] = Array[i];
                    Array[i] = a;
                }
            }

        }
        static void Inserting()
        {
            int j, a;
            for (int i = 1; i < Array.Length; i++)
            {
                a = Array[i];
                j = i - 1;
                while (j >= 0 && Array[j] > a)
                {
                    Array[j + 1] = Array[j];
                    j = j - 1;
                }
                Array[j + 1] = a;
            }

        }
        static void Random()
        {
            Array = new int[60];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = RND.Next(100);
            }
        }
        static Random RND = new Random();
        static int[] Array;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bubble");
            Random();
            Bubble_sort();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nMin");
            Random();
            Min_sorting();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nMax");
            Random();
            Max_sorting();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\nInsert");
            Random();
            Inserting();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}\t", Array[i]);
            }
            Console.ReadKey();
        }
    }
}

