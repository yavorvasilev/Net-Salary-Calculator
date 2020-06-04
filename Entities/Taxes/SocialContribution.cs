namespace NetSalaryCalculator.Entities.Taxes
{
	using System;

	using static TaxConstants;
	 
	public class SocialContribution : Tax
	{
		public SocialContribution(decimal grossSalary) : base(grossSalary)
		{
		}

		internal override void Calculate(decimal grossSalary, out decimal taxBase, out decimal taxIncome)
		{
			if (grossSalary > SocialContributionТhreshold)
			{
				taxBase = SocialContributionТhreshold - NonTaxableIncome;
				taxIncome = Math.Round(taxBase * SocialContributionTaxRate, 2);
				return;
			}
			else if (grossSalary > NonTaxableIncome)
			{
				taxBase = grossSalary - NonTaxableIncome;
				taxIncome = Math.Round(taxBase * SocialContributionTaxRate, 2);
				return;
			}

			taxBase = 0;
			taxIncome = 0;
		}
	}
}
