namespace PracticaOCP
{
	public class TaxCalculatorCountry
	{
		public static ITaxCalculator GetTaxCalculator(string country)
		{
			switch (country)
			{
				case "India":
					return new IndiaTaxCalculator();
				case "USA":
					return new USATaxCalculator();
				case "UK":
					return new UKTaxCalculator();
				default:
					throw new ArgumentException("Pais No soportado.");
			}
		}
	}
}
