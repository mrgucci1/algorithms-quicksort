using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program sorter = new Program();
                int numCase = 0;
                //Console.WriteLine("Enter Number of Total Cases");
                //get total cases
                numCase = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numCase; i++)
                {
                    int[] numPerCase = new int[15000];
                    string[] caseStrings = new string[15000];
                    int counter = 0;
                    int temp3 = (i + 1);
                    //set the amount of strings per case
                    //Console.WriteLine("Enter Number of strings for case: " + temp3);
                    numPerCase[i] = Convert.ToInt32(Console.ReadLine());
                    //read in the amount of strings per 
                    for (int x = 0; x < numPerCase[i]; x++)
                    {
                        int temp = (x + 1);
                        int temp2 = (i + 1);
                        //Console.WriteLine("Enter string number: " + temp + " for test case " + temp2);
                        //get strings for current case
                        caseStrings[counter] = Console.ReadLine();
                        string compare = caseStrings[counter].ToString().Trim();
                        counter++;
                    }
                    //call quick start to sort array
                    quickStart(caseStrings, 0, caseStrings.Length - 1);
                    //print final array
                    for (int y = 0; y < caseStrings.Length; y++)
                    {
                        //string temp = mergedArray[y].ToString().Trim();
                        if (caseStrings[y] != "" && caseStrings[y] != null)
                            Console.WriteLine(caseStrings[y]);
                    }
                }
            }
            catch(Exception)
            {
                Environment.Exit(0);
            }
            Environment.Exit(0);
    }
        public static void quickStart(string[] array, int start, int end)
        {
            if (start < end)
            {
                //create split int which calls partition
                int split = Partition(array, start, end);
                if (split > 1)
                {
                    quickStart(array, start, split - 1);
                }
                if (split + 1 < end)
                {
                    quickStart(array, split + 1, end);
                }
            }
        }
        public static int Partition(string[] array, int start, int end)
        {
            string split = array[start];
            while (true)
            {
                //compare left side of the array to split
                while (string.CompareOrdinal(array[start], split) < 0)
                {
                    start++;
                }
                //compare right side of array to split
                while (string.CompareOrdinal(array[end], split) > 0)
                {
                    end--;
                }
                //if left < right, go in
                if (start < end)
                {
                    if (array[start] == array[end])
                        return end;
                    //update array
                    string temp = array[start];
                    array[start] = array[end];
                    array[end] = temp;
                }
                else
                {
                    return end;
                }
            }
        }
    }
}