using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp4
{
	public partial class FormAdd : Form
	{
		private Product Changable;
		public FormAdd()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{

			try
			{
				int index = int.Parse(maskIndex.Text);
				// проверяет добавлен или нет
				if (FormMain.products.Contains(new Product(index)))
				{
					MessageBox.Show("Товар с таким индексом уже существет!!!");
					return;
				}

				string country = textCountry.Text;
				textStength.Text += textStength.Text.Contains(",") ? "" : ",0";
				double strength = double.Parse(textStength.Text);
				textPrice.Text += textPrice.Text.Contains(",") ? "" : ",0";
				double price = double.Parse(textPrice.Text);
				int amount = int.Parse(textAmount.Text);

				string name = textName.Text;

				foreach (Product x in FormMain.products)
				{
					if (name == x.Name)
					{
						MessageBox.Show("Такой товар уже существует\r\nПопробуйте добавить количество");
						return;
					}
				}

				Product product = new Product(index, name, country, strength, price, amount);
				FormMain.products.Add(product);
			}
			catch
			{
				MessageBox.Show("Введены не все строчки");
			}
			
		}

		private void textName_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsLetter(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void textCountry_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsLetter(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44)
			{
				e.Handled = true;
			}
		}

		private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44)
			{
				e.Handled = true;
			}
		}

		private void textCountry_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}

		private void btChange_Click(object sender, EventArgs e)
		{
			if (Changable != null)
			{
				Changable.Index = int.Parse(maskIndex.Text);
				Changable.Name = textName.Text;
				Changable.Country = textCountry.Text;
				Changable.Strength = double.Parse(textStength.Text);
				Changable.Price = double.Parse(textPrice.Text);
				Changable.Amount = int.Parse(textAmount.Text);

				Changable = null;

				FormMain.products.ResetBindings();
				MessageBox.Show("Данные обновлены");
				Clear();
				
			}
		}
		private void Clear()
		{
			maskIndex.Text = "";
			textName.Text = "";
			textCountry.Text = "";
			textStength.Text = "";
			textPrice.Text = "";
			textAmount.Text = "";
		}
		private void btSearch_Click(object sender, EventArgs e)
		{
			foreach (Product x in FormMain.products)
			{
				if (int.Parse(maskIndex.Text) == x.Index)
				{
					textName.Text = x.Name;
					textCountry.Text = x.Country;
					textStength.Text = x.Strength.ToString();
					textPrice.Text = x.Price.ToString();
					textAmount.Text = x.Amount.ToString();
					Changable = x;
					
					break;
				}
			}
		}
	}
}

