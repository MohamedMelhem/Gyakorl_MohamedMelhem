using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorló0404
{
	public class SultHusok : Etel
	{

		public SultHusok(double caloriesPerDkg, double weight, string name, bool isDairyFree)
			: base(caloriesPerDkg, weight, name)
		{
			IsItDairyFree = isDairyFree;
		}


		public override double CountCalories()
		{
			return (caloriesPerDkg * weight) / 10;
		}
	}

}
