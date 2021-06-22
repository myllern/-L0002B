using System;
using System.Globalization;

namespace Inl3
{

public class Person
{
		private string FName, LName, PrNr;

		//Skapar en ny person med information som skickas från OkClicker i Form1.
		public Person(string fname, string lname, string prnr )
	{
			FName = fname;
			LName = lname;
			PrNr = prnr;
		}
	//Returnerar personens förnamn.
	public string GetFName()
	{
			return FName;
	}
	//Returnerar personens efternamn. 
	public string GetLName()
		{
			return LName;
		}
	//Returnerar persons personnummer.
	public string GetPrNr()
		{
			return PrNr;
		}
	
	//Returnerar personens kön som bestäms via personnummer.
	public string GetGender()
		{ 
			return (CharUnicodeInfo.GetDecimalDigitValue(PrNr[8]) % 2 == 1) ?  "Man" : "Kvinna";
		}
		
	//Validerar personnummer enligt algoritmen i uppgiftsspecifikationen och returnerar om det är giltigt eller ogiltigt.
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
			return (sum % 10 == 0) ? "Giltigt nummer" : "Ogiltigt nummer";

		}
	}
}