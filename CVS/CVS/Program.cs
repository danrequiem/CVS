using System;

namespace CSV
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Funciones fun =  new Funciones();
				fun.Ejecutar();
				Console.ReadLine();
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Cerrando la lectura.");
			}
			
		
		}
	}
}