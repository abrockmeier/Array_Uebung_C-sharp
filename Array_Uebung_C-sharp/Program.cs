using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Uebung_C_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
			int [] zahlen5 = new int [5];
			
			int [] zahlen7;
			zahlen7 = new int [7];

			int [] zahlen3 = new int[] {4, 5, 6}; // Array direkt mit Zahlen füllen
			/*
					// Array per Zählschleife mit Zahlen füllen
				for (int i = 0; i < zahlen5.Length; i++)
				{
					zahlen5[i] = i*2;
				}
					// Array auslesen
				for (int i = 0; i < zahlen5.Length; i++)
				{
					Console.WriteLine(zahlen5[i]);
				}
			 */

			Console.WriteLine("---I---");
			int anzahl = 7;
			zahlen7 = new int[anzahl];  //Beim ansprechen des gesamten Array´s eine eckigen Klammern vorne!

				// Array per Zählschleife mit Zahlen füllen
			for (int i = 0; i < zahlen7.Length; i++)
			{
				zahlen7[i] = i*2;
			}

				// Array auslesen II
			for (int i = 0; i < zahlen7.Length; i++)
			{
				Console.WriteLine(zahlen7[i]);
			}
			

			Console.WriteLine("---II---");

			int [] sichern = new  int[anzahl]; //oder [zahlen7.Length]...

			for (int i = 0; i < zahlen7.Length; i++)
			{
				sichern[i] = zahlen7[i]*2; //Sichern enthält das Quadrat der in 
				//zahlen7 enthaltenen Werte der Elemente.
			}
			
			Console.WriteLine("---III----");
			// Array auslesen III
			for (int i = 0; i < sichern.Length; i++)
			{
				Console.WriteLine(sichern[i]);
			}
			Console.WriteLine("---IV--");
			zahlen7 = new int [20];

			// Array per Zählschleife mit Zahlen füllen
			for (int i = 0; i < sichern.Length; i++)
			{
				zahlen7[i] = sichern[i];
			}
			Console.WriteLine("---V---");


			// Array auslesen II
			for (int i = 0; i < zahlen7.Length; i++)
			{
				Console.WriteLine(zahlen7[i]);
			}
			Console.WriteLine("---VI--");

			// Array per foreach Zählschleife auslesen
			Console.WriteLine("Ausgabe: zahlen7");

			 foreach (int element in zahlen7) // Zugriff hier nicht über index[] sondern element!
			 {
				Console.WriteLine(element);
			 }
			Console.ReadKey();
		}
	}
}
