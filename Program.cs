using System;

namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
			// Preamble String
			String preamble = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defense, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";
			// Characters to be trimmed/ignored that are in the preamble
			char[] trimItems = { ',', '.' };
			string[] strList = preamble.Split();
			// counters for the three conditions being searched for
			int[] count = { 0, 0, 0 };

			for (int i = 0; i < strList.Length; i++)
			{
				// temporary string that can be modified to remove any unnecessary characters
				string s = strList[i];
				s = s.TrimEnd(trimItems);
				
				if (s[0] == 't')
					count[0]++;
				if (s[s.Length - 1] == 'e')
					count[1]++;
				if (s[0] == 't' && s[s.Length - 1] == 'e')
					count[2]++;
			}
			Console.WriteLine("Number of words beginning with t:			" + count[0]);
			Console.WriteLine("Number of words ending with e:				" + count[1]);
			Console.WriteLine("Number of words beginning with t and ending with e:	" + count[2]);
			Console.WriteLine("Press any key to continue");
			Console.ReadLine();
		}
    }
}
