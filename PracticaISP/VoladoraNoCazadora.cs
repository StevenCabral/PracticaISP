namespace PracticaISP
{
	class VoladoraNoCazadora : Ivolador, ICantor, IPoneHuevos
	{
		public string NombreEspecie { get; set; }

		public VoladoraNoCazadora(string nombre)
		{
			NombreEspecie = nombre;
		}

		public void Volar()
		{
			Console.WriteLine($"{NombreEspecie} puede volar.");
		}

		public void Cantar()
		{
			Console.WriteLine($"{NombreEspecie} puede cantar.");
		}

		public void PonerHuevos()
		{
			Console.WriteLine($"{NombreEspecie} puede poner huevos.");
		}
	}

}
