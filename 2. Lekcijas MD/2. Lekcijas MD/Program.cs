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


			//--------------UZDEVUMS NO 5 ------------------------------------

			Console.WriteLine("5. Uzdevums");

			Console.WriteLine("Ievadi skaitli ko dalīsim ar 2 un parādīsim atlikumu: ");
			string modulus = Console.ReadLine();

			int modRes = int.Parse(modulus);

			Console.WriteLine(modRes%2); 

			//--------------UZDEVUMS NO 6 ------------------------------------

			Console.WriteLine("6. Uzdevums");

			Console.WriteLine("Ievadi skaitli: ");
			string oddEven = Console.ReadLine();

			int resOddEven = int.Parse(oddEven);

			int odd = resOddEven % 2;
			bool resOdd = odd == 0;

			Console.WriteLine("Vai skaitlis: " + resOddEven + " ir pāra skaitlis? Atbilde: "+ resOdd);   // Šis uzdevums liekas ka nav īsti tā kā vajag.

			//--------------UZDEVUMS NO 7 ------------------------------------

			Console.WriteLine("7. Uzdevums");

			Console.WriteLine("Ievadi taisnstūra pamatu:");
			string rectangleWidth = Console.ReadLine();

			Console.WriteLine("Ievadi taisnstūra augstumu");
			string rectangleHeight = Console.ReadLine();

			double rectangleW = double.Parse(rectangleWidth);
			double rectangleH = double.Parse(rectangleHeight);

			double rectangleSquare = rectangleH * rectangleW;
			double roundRectangleSquare = Math.Round(rectangleSquare, 2);

			Console.WriteLine(roundRectangleSquare);

			//--------------UZDEVUMS NO 8 ------------------------------------

			Console.WriteLine("8. Uzdevums");

			Console.WriteLine("Ievadi vienādsānu taisnleņķa trijstūra malas garumu:");

			string triangleEdgeText = Console.ReadLine();
			int triangleEdge = int.Parse(triangleEdgeText);

			int triangleSquare = triangleEdge * triangleEdge / 2;

			Console.WriteLine(triangleSquare);

			//--------------UZDEVUMS NO 9 ------------------------------------

			Console.WriteLine("9. Uzdevums");

			Console.WriteLine("Kāds ir Tavs vārds?");
			string name = Console.ReadLine();

			Console.WriteLine("Kāds ir Tavs vecums?");
			string ageText2 = Console.ReadLine();

			int age2 = int.Parse(ageText2);
			

			Console.WriteLine("Sveiks, {0} Tavs vecums ir {1} gadi!", name, age2);







		}
	}
}
