namespace PracticaOCP
{
	public class USATaxCalculator : ITaxCalculator
	{
		public decimal CalculateTax(decimal income, decimal deduction)
		{
			decimal taxableIncome = income - deduction;
			
			decimal taxAmount = taxableIncome * 0.20m; 
			return taxAmount;
		}
	}
}
