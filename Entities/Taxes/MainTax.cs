namespace NetSalaryCalculator.Entities.Taxes
{
    using System;

    using static TaxConstants;

	public class MainTax : Tax
	{
		public MainTax(decimal grossSalary) 
			: base(grossSalary)
		{
		}

		internal override void Calculate(decimal grossSalary, out decimal taxBase, out decimal taxIncome)
		{
			if (grossSalary > NonTaxableIncome)
			{
				taxBase = grossSalary - NonTaxableIncome;
				taxIncome = Math.Round(taxBase * TaxRate, 2);
				return;
			}

			taxBase = 0;
			taxIncome = 0;
		}

		
	}
}
