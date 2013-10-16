using System;
using System.IO;
using System.Collections;

namespace CSV
{
	
	public class Funciones
	{	
		 private ArrayList Personas = new ArrayList();
		 private Registro persona = new Registro();
		 
		public Funciones()
		{
			this.persona = new Registro();
			this.Personas = new ArrayList();
		}
		public void Ejecutar()
		{
			leeArchivo();
			imprimirRegistros();
		}
		public void leeArchivo()
		{
			string ubicacion;
			try
			{
				Console.WriteLine("Dame la ubicacion de el arcihvo");
				ubicacion = Console.ReadLine();
				
				StreamReader objReader = new StreamReader(ubicacion);
				objReader.GetType();
				
				
				string sLine= objReader.ReadLine();
				ArrayList arrText = new ArrayList();
	
					while (sLine != null)
					{
						agregaResisgtro(sLine);
						sLine = objReader.ReadLine();	
					}
		             objReader.Close();
	
	
	               
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
		public void agregaResisgtro(string sLine)
		{
			
				char[] delimiterChars = {','};
				string[] words = sLine.Split(delimiterChars);
				
				Registro persona = new Registro();
				persona.id = words[0];
				persona.nombre = words[1];
				persona.domicilio = words[2];
				persona.telefono = words [3];
			
				Personas.Add(persona);
				
	
	
		}
		public void imprimirRegistros()
		{
			Console.WriteLine("Numero de registros"+Personas.Count);
			foreach (object Registro in Personas)
	        {
				this.persona = (Registro) Registro;
				imprimirTodos();
				
	        }

		}
		public void imprimirTodos()
		{
			Console.WriteLine("----------------------------------------");
			Console.Write("ID:");
			Console.WriteLine(this.persona.id);
			Console.Write("Nombre:");
			Console.WriteLine(this.persona.nombre);
			Console.Write("Telefono:");
			Console.WriteLine(this.persona.nombre);
			Console.Write("Domicilio:");
			Console.WriteLine(this.persona.domicilio);
			Console.WriteLine("----------------------------------------");
			
		}
	}
}
