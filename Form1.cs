using System;
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
			}

			GenerateNewTable();
		}

		private void NameItemButtonClick(object sender, EventArgs e)
		{
			Button delete_button = (Button)sender;
			int row = TablePanel.GetRow(delete_button);

			var bar = (ProgressBar)TablePanel.GetControlFromPosition(2, row);
			if (bar.Value < bar.Maximum) bar.Value += 1;

			Item_Values_List[row] = bar.Value;
		}

		private void DeleteItemButtonClick(object sender, EventArgs e)
		{
			Button delete_button = (Button)sender;
			int row = TablePanel.GetRow(delete_button);

			Item_Names_List.RemoveAt(row);
			Item_Values_List.RemoveAt(row);

			GenerateNewTable();
		}

		private void GenerateNewTable()
		{
			TablePanel.Controls.Clear();

			for (int i = 0; i < Item_Names_List.Count; i++)
			{

				Button button = new Button()
				{
					Text = Item_Names_List[i]
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
				delete.Click += new EventHandler(this.DeleteItemButtonClick);

				if (TablePanel.RowCount < i) TablePanel.RowCount += 1;

				TablePanel.Controls.Add(button, 0, i);
				TablePanel.Controls.Add(delete, 1, i);
				//TablePanel.Controls.Add(text, 2, i);
				TablePanel.Controls.Add(bar, 2, i);
			}
		}
	}
}
