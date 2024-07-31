namespace PracticaOCP
{
	public interface ITaxCalculator
	{
		decimal CalculateTax(decimal income, decimal deduction);
	}
}
