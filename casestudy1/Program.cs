using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
	class EmployeePromotion
	{
		static void Main(string[] args)
		{
			List<string> employeenames = new List<string>();
			for (int i = 1; i <= 5; i++)

			{
				employeenames.Add(Console.ReadLine());
			}
			Console.WriteLine("employee names in a list");
			foreach(var list in employeenames)
			{
				Console.WriteLine(list + "");
		    }

			Console.WriteLine("Please enter the name ");
			string name= Console.ReadLine();
			int index = employeenames.IndexOf(name);

			Console.WriteLine(index+"");
			Console.ReadLine();



		}
	}
}
