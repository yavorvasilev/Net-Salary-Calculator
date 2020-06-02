namespace NetSalaryCalculator
{
	using System;
	public class Startup
	{
		static void Main()
		{
			Console.WriteLine("----------Net Salary Calculator----------");
		
			do
			{
				bool isValidInput = false;

				while (!isValidInput)
				{
					decimal grossSalary;

					try
					{
						Console.Write("\nEnter the emplyee name: ");
						string name = Console.ReadLine().Trim();
						
						Console.Write("Enter the gross salary: ");
						string inputSalary = Console.ReadLine();

						if (Validator.ValidateName(name) && Validator.TryParceSalary(inputSalary, out grossSalary))
						{
							EmployeeInfo info = new EmployeeInfo(name, grossSalary);
							Console.WriteLine(info);

							isValidInput = true;
						}
					}
					catch (Exception exception)
					{
						Print.Error(exception.Message);
					}
				}

				Console.WriteLine("!!!Press Q to quit or any others key to continue.!!!");

			} while (Console.ReadKey().Key != ConsoleKey.Q);
		}
	}
}
