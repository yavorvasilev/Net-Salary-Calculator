namespace NetSalaryCalculator.Exceptions
{
	using System;

	public class InvalidEmployeeNameException : Exception
	{
		public InvalidEmployeeNameException(string message) 
			: base(message)
		{
		}
	}
}
