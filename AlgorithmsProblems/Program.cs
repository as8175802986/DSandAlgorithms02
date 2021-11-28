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
                Console.WriteLine("Enter your Choice to Execute the Program Press- 1-Binary Search,2-Exit");
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
                        flag = false;
                        break;
                }
            }

        }
    }
}
