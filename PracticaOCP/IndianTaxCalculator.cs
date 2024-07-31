namespace PracticaOCP
{
	public class IndiaTaxCalculator : ITaxCalculator
	{
		public decimal CalculateTax(decimal income, decimal deduction)
		{
			decimal taxableIncome = income - deduction;
			
			decimal taxAmount = taxableIncome * 0.10m; 
			return taxAmount;
		}
	}
}
