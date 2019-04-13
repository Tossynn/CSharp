using System;

class Analysis
{
	static void Main(string[] args)
	{
		int passes = 0,
			failures = 0,
			student = 1,
			result;
			
		while(student <= 10)
		{
			Console.Write("Enter result (1=pass, 2=fail): ");
			result = Int32.Parse(Console.ReadLine());
			
			if (result == 1)
				passes += 1;
			else
				failures = failures + 1;
				student += 1;
		}
		Console.WriteLine();
		Console.WriteLine("Passed: " + passes);
		Console.WriteLine("Failed: " + failures);
		
		if (passes > 8)
			Console.WriteLine("Raise Tuition\n");
	}
}