using System;

namespace LinearSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = new int[args.Length];
            if(args.Length == 0 || args.Length == 1)
            {
                Console.WriteLine("Please enter numeric arguments.");
                Console.WriteLine("Usage: dotnet LinearSearch.dll <num1> <num2> <num3> ...(atleast 2 nums)");
            }
            else
            {
                for(int i=0; i<args.Length; i++)
                {
                    input[i] = int.Parse(args[i]);
                }

                for(int i=0; i<input.Length-2; i++)
                {
                    if(input[i] == input[input.Length-1])
                    {
                        Console.WriteLine("Integer {0} found at index {1}",input[input.Length-1],i);
                        break;
                    }
                    else if(i==input.Length-2)
                        Console.WriteLine("Integer {0} could not be found in array.",input[input.Length-1]);
                }
            }                
        }
    }
}
