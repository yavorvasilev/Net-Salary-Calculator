using System;
using System.Collections.Generic;
using System.Text;

namespace NetSalaryCalculator.Entities.Taxes
{
	abstract public class Tax : ITax
	{
		public Tax(decimal grossSalary)
		{
			decimal taxBase;
			decimal taxIncome;
			Calculate(grossSalary, out taxBase, out taxIncome);

			TaxBase = taxBase;
			TaxIncome = taxIncome;
		}

		public decimal TaxBase { get; }

		public decimal TaxIncome { get; }

		abstract internal void Calculate(decimal grossSalary, out decimal taxBase, out decimal taxIncome);
	}
}
