namespace NetSalaryCalculator
{
	using System;
    using System.Text;

    public class EmployeeInfo
	{
		private decimal taxBase;
		private decimal incomeTax;
		private decimal socialContributionTaxBase;
		private decimal socialContributionTax;
		private decimal totalTaxes;
		private decimal netSalary;

		public EmployeeInfo(string name, decimal grossSalary)
		{
			Name = name;
			GrossSalary = Math.Round(grossSalary, 2);

			CalculateTaxes();
		}
		public string Name { get; private set; }
		public decimal GrossSalary { get; private set; }

		private void CalculateTaxes() 
		{
			TaxesCalculator.Calculate(
				GrossSalary,
				out taxBase,
				out incomeTax,
				out socialContributionTaxBase,
				out socialContributionTax
				);

			totalTaxes = incomeTax + socialContributionTax;
			netSalary = GrossSalary - totalTaxes;
		}

		public override string ToString()
		{
			var employeeInfo = new StringBuilder();
			employeeInfo.Append("---***Employee salary information: ***---");

			if (totalTaxes != 0)
			{
				return employeeInfo.Append($"\n{Name} has a salary of {GrossSalary:0.00} IDR." +
					$"\nIncome tax : 10% out of {taxBase:0.00} => {incomeTax:0.00}." +
					$"\nSocial contributions are 15% out of {socialContributionTaxBase:0.00} => {socialContributionTax:0.00}." +
					$"\nTotal taxes: {totalTaxes:0.00} " +
					$"\nGross salary: {netSalary:0.00} IDR").ToString();
			}
			return employeeInfo.Append($"\n{Name} has a salary of {GrossSalary:0.00} IDR." +
				$"\n{Name} would pay no taxes since this is below the taxation threshold." +
				$"\n{Name}'s net income is also {netSalary:0.00}.").ToString();
		}
	}
}
