using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
            // Console.WriteLine(CheckScore()); // call the CheckScore function and get the output
        }

        static int CheckScore()
        {
            int[] arr = new int[5]; // define an array
            Console.WriteLine("Please insert a number of your array length");
            int arrlength = Convert.ToInt32(Console.ReadLine()); // ask user to insert the length of array
            Console.WriteLine("Please fill your list");
            for (int i = 0; i < arrlength; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine()); // ask user to insert element of array using loop
                arr[i] = n; // insert the user input in my array
            }
            Console.WriteLine("Please fill the number from your array");
            int number = Convert.ToInt32(Console.ReadLine()); // ask user to insert the number to check in array
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return number * count;
            }
        }
    }
}
