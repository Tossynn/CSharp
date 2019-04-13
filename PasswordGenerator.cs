using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

class PGen
{
	static string generatePword(int length)
	{
		const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		StringBuilder res = new StringBuilder();
		Random rnd = new Random();
		while (0 < length--)
		{
			res.Append(validChars[rnd.Next(validChars.Length)]);
		}
		return res.ToString();
	}
	static void  Main()
	{
		//password length
		int length = 7;
		string pass = generatePword(length);
		Console.Write(pass);
	}

}