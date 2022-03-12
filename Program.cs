using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			// Console.WriteLine(IsLeapYear());// call the IsLeapYear function and get the output
		}

        static string IsLeapYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                return "Yes it is a Leap Year.";
            }
            else
            {
                return "No it is not a Leap Year.";
            }
        }

    }
}
