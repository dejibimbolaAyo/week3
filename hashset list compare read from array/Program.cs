using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace hashset_list_compare_read_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myWatch1 = new Stopwatch();
            Stopwatch myWatch2 = new Stopwatch();
            HashSet<int> myHashset = new HashSet<int>();
            List<int> myList = new List<int>();
            int[] myArray = new int[1000000];
            Random myRandGen = new Random();

            //_________________________________________________________________________________
            for (int i = 0; i < 1000000; i++)
            {
                myArray[i] = myRandGen.Next(1000, 10000);

            }
            //_________________________________________________________________________________

            myWatch1.Start();
            for (int j = 0; j < 1000000; j++)
            {
                myList.Add(myArray[j]);
            }

            int iterate1 = 0;
            foreach (int num in myList)
            {
                if (num < 5000)
                {
                    Console.WriteLine(num);

                    iterate1++;
                    if (iterate1 == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("----------------------------------------------------------------");
            myWatch1.Stop();
            Console.WriteLine("List Adds, Enumerates and Searches in {0} milliseconds", myWatch1.ElapsedMilliseconds);
            Console.WriteLine("----------------------------------------------------------------");

            //_________________________________________________________________________________

            myWatch2.Start();
            for (int k = 0; k < 1000000; k++)
            {
                myHashset.Add(myArray[k]);
            }

            int iterate2 = 0;
            foreach (int num2 in myHashset)
            {
                if (num2 < 5000)
                {
                    Console.WriteLine(num2);
                    iterate2++;
                    if (iterate2 == 10)
                    {
                        break;
                    }
                }

            }
            Console.WriteLine("----------------------------------------------------------------");
            myWatch2.Stop();
            Console.WriteLine("HashSet Adds, Enumerates and Searches in {0} milliseconds", myWatch2.ElapsedMilliseconds);
            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadLine();
        }
        

    }
}

   
