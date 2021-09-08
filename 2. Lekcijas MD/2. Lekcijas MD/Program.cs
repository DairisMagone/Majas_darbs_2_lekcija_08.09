using System;

namespace _2._Lekcijas_MD
{
	class Program
	{
		static void Main(string[] args)
		{

			//--------------UZDEVUMS NO 1 ------------------------------------

			Console.WriteLine("1. Uzdevums");

			Console.WriteLine("Kā tevi sauc?");

			string yourName = Console.ReadLine();

			Console.WriteLine("Sveiks," + yourName + "!");

			//--------------UZDEVUMS NO 2 ------------------------------------

			Console.WriteLine("2. Uzdevums");

			Console.WriteLine("Kāds ir Tavs vecums?");

			string ageText = Console.ReadLine();

			int age = int.Parse(ageText);
			int previousAge = age + 1;

			Console.WriteLine("Nākamgad Tev paliks " + previousAge + " gadi");



			//--------------UZDEVUMS NO 3 & 4 ------------------------------------

			Console.WriteLine("3. un 4. Uzdevums");

			Console.WriteLine("Ievadi pirmo skaitli");
			string number1 = Console.ReadLine();

			Console.WriteLine("Ievadi otro skaitli");
			string number2 = Console.ReadLine();

			int num1= int.Parse(number1);
			int num2 = int.Parse(number2);
			int maxNum = Math.Max(num1, num2);
			int minNum = Math.Min(num1, num2);

			Console.WriteLine("Lielākais skaitlis: " + maxNum);
			Console.WriteLine("Mazākais skaitlis: " + minNum);


			//--------------UZDEVUMS NO 3 & 4 ------------------------------------

			Console.WriteLine("3. un 4. Uzdevums");











		}
	}
}
