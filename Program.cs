using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			//int[] perfect = { 1, 2, 3 };
			//Console.WriteLine(IsPerfect(perfect));
		}

        static string IsPerfect(int[] sequence)
        {

            int product = 1;
            int sum = 0;
            foreach (int number in sequence)
            {
                if (number < 0)
                {
                    return "No";
                }
                product *= number;
                sum += number;
            }
            if (product == sum)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
