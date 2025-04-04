using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorló0404
{
	public abstract class Etel
	{
		protected double caloriesPerDkg;
		protected double weight;
		protected string name;
		public string Name { get;}

		public bool IsItDairyFree { get; set; } = false;



		protected Etel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.Name = name;
		}


		public abstract double CountCalories();
	}
}