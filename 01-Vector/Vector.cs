using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
	class Vector
	{
		public double x, y;

		public Vector(double x = 0, double y = 0) //konstruktor
		{
			this.x = x;
			this.y = y;
		}

		public void Vypis()
		{
			Console.WriteLine("({0}, {1})", x, y);
		}

		public Vector Secti(Vector vec)
		{
			return new Vector(x + vec.x, y + vec.y);
		}

		public double Soucin(Vector vec)
		{
			return (this.x * vec.x) + (this.y) * (vec.y);
		}

		public double Uhel(Vector vec)
		{
			return Math.Acos((this.x * vec.x + this.y * vec.y) / (Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)) * Math.Pow(vec.x, 2) + Math.Pow(vec.y, 2)));
		}
	}
}
