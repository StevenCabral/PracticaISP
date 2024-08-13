namespace PracticaISP
{
	class NadadoraNoVoladora : ICantor, IPoneHuevos, INadador
	{
		public string NombreEspecie { get; set; }

		public NadadoraNoVoladora(string nombre)
		{
			NombreEspecie = nombre;
		}

		public void Cantar()
		{
			Console.WriteLine($"{NombreEspecie} puede cantar.");
		}

		public void PonerHuevos()
		{
			Console.WriteLine($"{NombreEspecie} puede poner huevos.");
		}

		public void Nadar()
		{
			Console.WriteLine($"{NombreEspecie} puede nadar.");
		}
	}

}
