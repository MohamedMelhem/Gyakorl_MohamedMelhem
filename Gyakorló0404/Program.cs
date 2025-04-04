namespace Gyakorló0404
{
	internal class Program
	{

		public static double SumCalories(List<Etel> etterem)
		{
			return etterem.Sum(etel => etel.CountCalories());
		}


		public static List<Etel> FilterDairyFree(List<Etel> etterem)
		{
			return etterem.Where(etel => etel.IsItDairyFree).ToList();
		}

		public static void Main(string[] args)
		{

			List<Etel> etterem = new List<Etel>
		{

            new Levesek(3.5, 250, "Zöldségleves", true),
			new Levesek(2.8, 300, "Húsleves", false),
			new Levesek(4.0, 200, "Gulyásleves", false),
            
 
            new Kenyerfelesek(2.5, 500, "Fehér kenyér", true),
			new Kenyerfelesek(3.0, 400, "Pékáru", false),
			new Kenyerfelesek(2.8, 300, "Teljes kiőrlésű kenyér", true),


            new SultHusok(4.5, 200, "Sült csirke", true),
			new SultHusok(5.0, 350, "Sült sertéshús", false),
			new SultHusok(6.0, 250, "Sült marhahús", false)
		};


			double totalCalories = SumCalories(etterem);
			Console.WriteLine("Összes kalória: " + totalCalories);

			
			var dairyFreeEtelek = FilterDairyFree(etterem);
			Console.WriteLine("\nDairy Free ételek:");
			foreach (var etel in dairyFreeEtelek)
			{
				Console.WriteLine($"{etel.Name}: {etel.CountCalories()} kalória");

			}


			double dairyFreeTotalCalories = SumCalories(dairyFreeEtelek);
			Console.WriteLine("\nDairy Free ételek összes kalóriája: " + dairyFreeTotalCalories);
		}
	}
}
