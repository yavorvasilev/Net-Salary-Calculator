namespace NetSalaryCalculator
{
    using NetSalaryCalculator.Exceptions;
    using System.Text.RegularExpressions;

	public static class Validator
	{
		static string namePattern = "^[A-Z][a-z]+( [A-Z][a-z]+)?$";
		public static bool ValidateName(string employeeName) 
		{
			if (!Regex.IsMatch(employeeName, namePattern))
			{
				throw new InvalidEmployeeNameException("Error: The name should contain first and last name or atleast first name." +
					"\nThe name should contain only latin letter and should start with upper letter.\n");
			}

			return true;
		}

		public static bool TryParceSalary(string salary, out decimal grossSalary)
		{
			if (!decimal.TryParse(salary.Replace('.', ','), out grossSalary) || grossSalary <= 0)
			{
				throw new InvalidEmployeeGrossSalaryException("Error: Gross salary should be a positive number greater than zero.\n");
			}

			return true;
		}
	}
}
