namespace PracticaISP
{
	class VoladoraCazadora : Ivolador, ICantor, IPoneHuevos, ICazador
	{
		public string NombreEspecie { get; set; }

		public VoladoraCazadora(string nombre)
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

		public void Cazar()
		{
			Console.WriteLine($"{NombreEspecie} puede cazar.");
		}
	}

}
