namespace NetSalaryCalculator
{
    using System;
	using NetSalaryCalculator.Entities;
	using NetSalaryCalculator.Entities.Taxes;

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
						Print.Info("\nEnter the emplyee name: ");
						string name = Console.ReadLine().Trim();
						
						Print.Info("Enter the gross salary: ");
						string inputSalary = Console.ReadLine();

						if (Validator.ValidateName(name) && Validator.TryParceSalary(inputSalary, out grossSalary))
						{
							EmployeeInfo info = new EmployeeInfo(
								name, 
								grossSalary, 
								new MainTax(grossSalary), 
								new SocialContribution(grossSalary));
							
							Print.Info(info.ToString());

							isValidInput = true;
						}
					}
					catch (Exception exception)
					{
						Print.Error(exception.Message);
					}
				}

				Print.Info("\n!!!Press Q to quit or any others key to continue!!!\n");

			} while (Console.ReadKey().Key != ConsoleKey.Q);
		}
	}
}
