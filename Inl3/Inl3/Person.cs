using System;
using System.Globalization;

namespace Inl3
{


public class Person
{
		private string FName, LName, PrNr;

		public Person(string fname, string lname, string prnr )
	{
			FName = fname;
			LName = lname;
			PrNr = prnr;
		}

	public string GetFName()
	{
			return FName;
	}

	public string GetLName()
		{
			return FName;
		}

	public string GetPrNr()
		{
			return PrNr;
		}

	public string GetGender()
		{ 
			return (CharUnicodeInfo.GetDecimalDigitValue(PrNr[8]) % 2 == 1) ?  "Man" : "Kvinna";
		}
		
	public string ValidateNr()
        {
			int sum = 0;
			int[] seq = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
			int s;

			for (int i = 0; i < 9; i++)
            {
				s = CharUnicodeInfo.GetDecimalDigitValue(PrNr[i]) * seq[i];
				if (s > 10)
				{
					sum += (s - 10 + 1) + s;
					
				}
				else {
					sum += s;
				}
				Console.WriteLine(s);
			}
			Console.WriteLine("sum");
			return (sum % 10 == 0) ? "Gilltigt nummer" : "Ogilltigt nummer";

		}
	}
}