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

namespace WindowsFormsApp4
{
	public partial class FormMain : Form
	{
		internal static BindingList<Product> products = new BindingList<Product>(); 
		public FormMain()
		{
			InitializeComponent();

			OutDisplay.AutoGenerateColumns = true;
			OutDisplay.DataSource = products;
			OutDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			OutDisplay.Columns[0].HeaderText = "Индекс";
			OutDisplay.Columns[1].HeaderText = "Марка напитка";
			OutDisplay.Columns[2].HeaderText = "Страна производителя";
			OutDisplay.Columns[3].HeaderText = "Крепкость напитка";
			OutDisplay.Columns[4].HeaderText = "Цена";
			OutDisplay.Columns[5].HeaderText = "Колчичество";

			OutDisplay.CellDoubleClick += OutDisplay_CellDoubleClick;

	
		}

		private void OutDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				textDelete.Text = OutDisplay.Rows[e.RowIndex].Cells[0].Value.ToString();
			}
			catch
			{
				MessageBox.Show("Выбран неверный символ");
			}
		}


		private void Delete_Click(object sender, EventArgs e)
		{
			try
			{
				products.Remove(new Product(int.Parse(textDelete.Text)));
			}
			catch
			{
				MessageBox.Show("Проверьте правильность указанных данных");
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			FormAdd newForm = new FormAdd();
			newForm.Show();
		}

		private void OutDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	
		private void LoadData(string path)
		{
			string[] go = File.ReadAllLines(path);
			try
			{
				for (int i = 0; i < go.Length; i++)
				{
					string[] join = go[i].Split(';');

					if (!FormMain.products.Contains(new Product(int.Parse(join[0]), join[1])))
						products.Add(new Product(int.Parse(join[0]), join[1], join[2], double.Parse(join[3]), double.Parse(join[4]), int.Parse(join[5])));

				}
			}
			catch
			{
				MessageBox.Show("Неверный формат");
			}
		}

		private void textSave_Click(object sender, EventArgs e)
		{
			
			string kakyoto = "";
			foreach (Product x in FormMain.products)
			{
				kakyoto += x.Index + ";" + x.Name + ";" + x.Country + ";" + x.Strength + ";" + x.Price + ";" + x.Amount + ";" + "\r\n";
			}
			File.WriteAllText(openFileDialog1.FileName, kakyoto);
		}

		private void textDelete_TextChanged(object sender, EventArgs e)
		{
			textDelete.MaxLength = 5;
		}

		private void BtOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			LoadData(openFileDialog1.FileName);																																																																																																																																																																		   
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}
