namespace PracticaOCP
{
	public class UKTaxCalculator : ITaxCalculator
	{
		public decimal CalculateTax(decimal income, decimal deduction)
		{
			decimal taxableIncome = income - deduction;
			
			decimal taxAmount = taxableIncome * 0.15m;
			return taxAmount;
		}
	}
}
