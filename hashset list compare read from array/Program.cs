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
            Stopwatch myWatch1 = new Stopwatch(); //instantiate an object for Stopwatch to track program execution
            Stopwatch myWatch2 = new Stopwatch();
            HashSet<int> myHashset = new HashSet<int>();// instatnce of object of data structures used in the program
            List<int> myList = new List<int>();
            int[] myArray = new int[1000000];// declaraton of array with space to hold 1000000 variables
            Random myRandGen = new Random(); // instance of a random object used to generate random numbers

            //_________________________________________________________________________________
            for (int i = 0; i < 1000000; i++)
            {
                myArray[i] = myRandGen.Next(1000, 10000); // this loop writes 1000000 random numbers bound 1000 t0 100000 into array

            }
            //_________________________________________________________________________________

            myWatch1.Start();// myWatch object tracks the time of execution to input into a List Structure, seach through a List Structure, and Print
            for (int j = 0; j < 1000000; j++)
            {
                myList.Add(myArray[j]); // this loop writes from array to list myList
            }

            int iterate1 = 0;
            foreach (int num in myList) // this block of codes finds and prints 1000 numbers inside myList less than 5000
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
            Console.WriteLine("List Adds, Enumerates and Searches in {0} milliseconds", myWatch1.ElapsedMilliseconds); //Prints Elapsed time for Execution involving List
            Console.WriteLine("----------------------------------------------------------------");

            //_________________________________________________________________________________

            myWatch2.Start(); // myWatch object tracks the time of execution to input into a HashSecture, seach through a HashSetre, and Print
            for (int k = 0; k < 1000000; k++)
            {
                myHashset.Add(myArray[k]); // this loop writes from array to HashSet myHashset
            }

            int iterate2 = 0;
            foreach (int num2 in myHashset) // this block of codes finds and prints 1000 numbers inside myHashsethan 5000
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
            Console.WriteLine("HashSet Adds, Enumerates and Searches in {0} milliseconds", myWatch2.ElapsedMilliseconds); //Prints Elapsed time for Execution involving HashSet
            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadLine();
        }
        

    }
}

   
