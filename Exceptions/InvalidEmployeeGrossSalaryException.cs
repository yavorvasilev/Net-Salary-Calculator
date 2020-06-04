namespace NetSalaryCalculator.Exceptions
{
	using System;

	public class InvalidEmployeeGrossSalaryException : Exception
	{
		public InvalidEmployeeGrossSalaryException(string message) 
			: base(message)
		{
		}
	}
}
