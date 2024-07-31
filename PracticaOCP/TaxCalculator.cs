namespace PracticaOCP
{
	public class TaxCalculator
	{
		public decimal Calculate(decimal income, decimal deduction, string country)
		{
			ITaxCalculator calculator = TaxCalculatorCountry.GetTaxCalculator(country);
			return calculator.CalculateTax(income, deduction);
		}
	}
}
