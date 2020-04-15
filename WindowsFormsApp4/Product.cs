using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
	class Product
	{
		private int index;
		private string name;
		private string country;
		private double strength;
		private double price;
		private int amount;

		public Product(int index)
		{
			this.Index = index;
			this.Name = "";
			this.Country = "";
			this.Strength = 0;
			this.Price = 0;
			this.Amount = 0;
		}

		public Product(int index, string name)
		{
			this.Index = index;
			this.Name = name;
			this.Country = "";
			this.Strength = 0;
			this.Price = 0;
			this.Amount = 0;
		}
		public Product(int index, string name, string country, double strength, double price, int amount)
		{
			this.Index = index;
			this.Name = name;
			this.Country = country;
			this.Strength = strength;
			this.Price = price;
			this.Amount = amount;
		}

		public int Index { get => index; set => index = value; }
		public string Name { get => name; set => name = value; }
		public string Country { get => country; set => country = value; }
		public double Strength { get => strength; set => strength = value; }
		public double Price { get => price; set => price = value; }
		public int Amount { get => amount; set => amount = value; }



		public override bool Equals(object obj) // метод сравнения
		{
			
			if (obj==null || obj.GetType() != this.GetType())
				return false;
			if ((obj as Product).index == index)
				return true;
			return false;
		}


	}
}
