using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Tracker
{
	public partial class Form1 : Form
	{
		public List<string> Item_Names_List = new List<string>();
		List<int> Item_Values_List = new List<int>();
		int maximum_progress_bar_value = 0;

		public Form1()
		{
			InitializeComponent();
			maximum_progress_bar_value = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

			string path = Directory.GetCurrentDirectory() + "/data.txt";
			ReadFile(path);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			Form2 popup_window = new Form2();
			popup_window.Items = Item_Names_List;
			if (popup_window.ShowDialog() == DialogResult.OK)
			{
				string item_name = popup_window.ItemName;
				if (!Item_Names_List.Contains(item_name))
				{
					Item_Names_List.Add(item_name);
					Item_Values_List.Add(0);
				}

				if (!SaveButton.Enabled) SaveButton.Enabled = true;
				
				GenerateNewTable();
			}

		}

		private void NameItemButtonClick(object sender, EventArgs e)
		{
			Button delete_button = (Button)sender;
			int row = TablePanel.GetRow(delete_button);

			var bar = (ProgressBar)TablePanel.GetControlFromPosition(3, row);
			if (bar.Value < bar.Maximum) bar.Value += 1;

			Item_Values_List[row] = bar.Value;

			if (!SaveButton.Enabled) SaveButton.Enabled = true;
		}

		private void MinusItemButtonClick(object sender, EventArgs e)
		{
			Button delete_button = (Button)sender;
			int row = TablePanel.GetRow(delete_button);

			var bar = (ProgressBar)TablePanel.GetControlFromPosition(3, row);
			if (bar.Value > 0) bar.Value -= 1;

			Item_Values_List[row] = bar.Value;

			if (!SaveButton.Enabled) SaveButton.Enabled = true;
		}

		private void DeleteItemButtonClick(object sender, EventArgs e)
		{
			Button delete_button = (Button)sender;
			int row = TablePanel.GetRow(delete_button);

			Item_Names_List.RemoveAt(row);
			Item_Values_List.RemoveAt(row);

			GenerateNewTable();

			if (!SaveButton.Enabled) SaveButton.Enabled = true;
		}

		private void GenerateNewTable()
		{
			TablePanel.Controls.Clear();

			for (int i = 0; i < Item_Names_List.Count; i++)
			{

				Button button = new Button()
				{
					Text = Item_Names_List[i],
					Width = 150
				};

				Button button_minus = new Button()
				{
					Text = "-"
				};

				Button delete = new Button()
				{
					Text = "X"
				};

				ProgressBar bar = new ProgressBar()
				{
					Value = Item_Values_List[i],
					MarqueeAnimationSpeed = 0,
					Size = new Size(500, 23),
					Maximum = maximum_progress_bar_value,
				};

				button.Click += new EventHandler(this.NameItemButtonClick);
				button_minus.Click += new EventHandler(this.MinusItemButtonClick);
				delete.Click += new EventHandler(this.DeleteItemButtonClick);

				if (TablePanel.RowCount < i) TablePanel.RowCount += 1;

				TablePanel.Controls.Add(button, 0, i);
				TablePanel.Controls.Add(button_minus, 1, i);
				TablePanel.Controls.Add(delete, 2, i);
				TablePanel.Controls.Add(bar, 3, i);
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			DialogResult _ = saveFileDialog1.ShowDialog();
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			string path = saveFileDialog1.FileName;

			string data = "";
			for (int i = 0; i < Item_Names_List.Count; i++)
			{
				string line = Item_Names_List[i].ToString() + ":" + Item_Values_List[i].ToString() + "\n";

				data += line;
			}

			File.WriteAllText(path, data);
			SaveButton.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult _ = openFileDialog1.ShowDialog();
		}

		private void ReadFile(string path)
		{
			if (File.Exists(path))
			{
				string[] file = File.ReadAllLines(path);

				foreach (string line in file)
				{
					string name_text = "";
					string number_text = "";

					bool is_second_value = false;

					foreach (char c in line)
					{
						if (c != ':' && !is_second_value) name_text += c;
						else if (c != ':' && is_second_value) number_text += c;

						if (c == ':') is_second_value = true;
					}

					int number = Convert.ToInt32(number_text);

					Item_Names_List.Add(name_text);
					Item_Values_List.Add(number);
				}

				GenerateNewTable();
				SaveButton.Enabled = false;
			}
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			Item_Names_List.Clear();
			Item_Values_List.Clear();

			string path = openFileDialog1.FileName;
			ReadFile(path);
		}
	}
}
