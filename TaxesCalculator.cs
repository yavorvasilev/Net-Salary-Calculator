namespace NetSalaryCalculator
{
	using System;
	public static class TaxesCalculator
	{
		const decimal NonTaxableIncome = 1000;
		const decimal SocialContributionТhreshold = 3000;
		const decimal TaxRate = 0.1M;
		const decimal SocialContributionTaxRate = 0.15M;

		public static void Calculate (decimal grossSalary, 
			out decimal taxBase, 
			out decimal incomeTax,
			out decimal socialContributionTaxBase,
			out decimal socialContributionTax
			) 
		{
			taxBase = 0;
			incomeTax = 0;
			socialContributionTaxBase = 0;
			socialContributionTax = 0;

			if (grossSalary > NonTaxableIncome)
			{
				taxBase = grossSalary - NonTaxableIncome;
				incomeTax = Math.Round(taxBase * TaxRate, 2);

				if (grossSalary > SocialContributionТhreshold)
				{
					socialContributionTaxBase = SocialContributionТhreshold - NonTaxableIncome;
					socialContributionTax = Math.Round(socialContributionTaxBase * SocialContributionTaxRate, 2);
				}
				else
				{
					socialContributionTaxBase = grossSalary - NonTaxableIncome;
					socialContributionTax = Math.Round(socialContributionTaxBase * SocialContributionTaxRate, 2);
				}
			}
		}
	}
}
