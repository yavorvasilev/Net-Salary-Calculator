namespace NetSalaryCalculator.Entities.Taxes
{
	public interface ITax
	{
		public decimal TaxBase { get; }
		public decimal TaxIncome { get; }
	}
}
