using System;
using System.Collections.Generic;
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
			int[] seq = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
			int sum = 0;

			int temp;
			List<string> list = new List<string>();
			for (int i = 0; i < 10; i++)
			{
			temp = seq[i] * int.Parse(PrNr[i].ToString());

			if(temp >= 10)
                {
					sum += temp - 9;
                }
                else
                {
					sum += temp;
                }
			};
			return (sum % 10 == 0) ? "Giltigt nummer" : "Ogiltigt nummer";		
		}
	}
}