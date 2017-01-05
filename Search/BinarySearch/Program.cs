using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
         int[] input = new int[args.Length-1];
            if(args.Length == 0 || args.Length == 1)
            {
                Console.WriteLine("Please enter numeric arguments.");
                Console.WriteLine("Usage: dotnet BinarySearch.dll <num1> <num2> <num3> ...(atleast 2 nums)");
            }
            else
            {
                for(int i=0; i<args.Length-1; i++)
                {
                    input[i] = int.Parse(args[i]);
                }
                int search = int.Parse(args[args.Length-1]);

                Array.Sort(input);
                int mid = 0;
                int low = 0;
                int up = input.Length-1;
                while (true)
                {
                    mid = low + (up-low)/2;

                    if(input[mid] > search)
                        up = mid - 1;

                    if(input[mid] < search)
                        low = mid + 1;

                    if(input[mid] == search)
                    {
                        Console.WriteLine("Integer {0} found at index {1}",search, mid);
                        break;
                    }

                    if(up < low)
                    {
                        Console.WriteLine("Integer {0} could not be found in given array.",search);
                        break;
                    }
                }
            }   
        }
    }
}
