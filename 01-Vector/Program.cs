using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector vec = new Vector();
			vec.x = 2;
			vec.y = 3;
			vec.Vypis();

			Vector nevec = new Vector();
			nevec.x = -69;
			nevec.y = 7;
			nevec.Vypis();

			Vector s = vec.Secti(nevec);
			double sc = vec.Uhel(nevec);
			Console.WriteLine(sc);
		}
	}
}
