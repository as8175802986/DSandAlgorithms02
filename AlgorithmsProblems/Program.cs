using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice to Execute the Program Press- 1-Binary Search,2-Bubble sort,3-InsertionShort,4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   
                    case 1:
                        string txtpath = File.ReadAllText(@"E:\DSandAlgorithms02\DSandAlgorithms02\AlgorithmsProblems\Utility\WordFile.txt");
                        List<string> words = new List<string>(txtpath.Split());
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;
                    case 2:
                        int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;
                    case 3:
                        InsertionShort insertionSort = new InsertionShort();
                        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }

        }
    }
}
