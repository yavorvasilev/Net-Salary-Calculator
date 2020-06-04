namespace NetSalaryCalculator.Entities
{
    using NetSalaryCalculator.Entities.Taxes;
    using System;
    using System.Text;

    public class EmployeeInfo
	{
		private ITax tax;
		private ITax socialContributions;
		private decimal totalTaxes;
		private decimal netSalary;

		public EmployeeInfo(string name, decimal grossSalary, ITax tax, ITax socialContributions)
		{
			Name = name;
			GrossSalary = Math.Round(grossSalary, 2);

			this.tax = tax;
			this.socialContributions = socialContributions;

			CalculateTaxes();
		}
		public string Name { get; private set; }
		public decimal GrossSalary { get; private set; }

		private void CalculateTaxes() 
		{
			totalTaxes = tax.TaxIncome + socialContributions.TaxIncome;
			netSalary = GrossSalary - totalTaxes;
		}

		public override string ToString()
		{
			var employeeInfo = new StringBuilder();
			employeeInfo.Append("\n---***Employee salary information: ***---\n");

			if (totalTaxes != 0)
			{
				return employeeInfo.Append($"\n{Name} has a salary of {GrossSalary:0.00} IDR." +
					$"\nIncome tax : 10% out of {tax.TaxBase:0.00} => {tax.TaxIncome:0.00}." +
					$"\nSocial contributions are 15% out of {socialContributions.TaxBase:0.00} => {socialContributions.TaxIncome:0.00}." +
					$"\nTotal taxes: {totalTaxes:0.00} " +
					$"\nGross salary: {netSalary:0.00} IDR\n").ToString();
			}
			return employeeInfo.Append($"\n{Name} has a salary of {GrossSalary:0.00} IDR." +
				$"\n{Name} would pay no taxes since this is below the taxation threshold." +
				$"\n{Name}'s net income is also {netSalary:0.00}.\n").ToString();
		}
	}
}
