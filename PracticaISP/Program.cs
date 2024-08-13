

using PracticaISP;

class Program
{
	static void Main(string[] args)
	{

		VoladoraCazadora aveVoladoraCazadora = new VoladoraCazadora("Ave Voladora y Cazadora");
		VoladoraNoCazadora aveVoladoraNoCazadora = new VoladoraNoCazadora("Ave Voladora pero No Cazadora");
		NadadoraNoVoladora aveNadadoraNoVoladora = new NadadoraNoVoladora("Ave Nadadora pero No Voladora");


		Console.Write("Ingrese el nombre de una especie para el ave voladora y cazadora: ");
		aveVoladoraCazadora.NombreEspecie = Console.ReadLine();

		Console.Write("Ingrese el nombre de una especie para el ave voladora pero no cazadora: ");
		aveVoladoraNoCazadora.NombreEspecie = Console.ReadLine();

		Console.Write("Ingrese el nombre de una especie para el ave nadadora pero no voladora: ");
		aveNadadoraNoVoladora.NombreEspecie = Console.ReadLine();


		Console.WriteLine($"Habilidades de {aveVoladoraCazadora.NombreEspecie}:");
		aveVoladoraCazadora.Volar();
		aveVoladoraCazadora.Cantar();
		aveVoladoraCazadora.PonerHuevos();
		aveVoladoraCazadora.Cazar();

		Console.WriteLine($"Habilidades de {aveVoladoraNoCazadora.NombreEspecie}:");
		aveVoladoraNoCazadora.Volar();
		aveVoladoraNoCazadora.Cantar();
		aveVoladoraNoCazadora.PonerHuevos();

		Console.WriteLine($"Habilidades de {aveNadadoraNoVoladora.NombreEspecie}:");
		aveNadadoraNoVoladora.Cantar();
		aveNadadoraNoVoladora.PonerHuevos();
		aveNadadoraNoVoladora.Nadar();


		Console.ReadKey();
	}
}
