using PracticaOCP;

class Program
{
	static void Main(string[] args)
	{
		TaxCalculator taxCalculator = new TaxCalculator();

		Console.WriteLine("Coloque la entrada: ");
		decimal income = Convert.ToDecimal(Console.ReadLine());

		Console.WriteLine("Coloque la deduccion: ");
		decimal deduction = Convert.ToDecimal(Console.ReadLine());

		Console.WriteLine("Seleccione un pais, (India, USA, UK): ");
		string country = Console.ReadLine();

		try
		{
			decimal taxAmount = taxCalculator.Calculate(income, deduction, country);
			Console.WriteLine($"El calculo de impuestos para {country} es: {taxAmount}");
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.Message);
		}

		
		Console.WriteLine("Pulse alguna tecla para salir...");
		Console.ReadKey();
	}
}
