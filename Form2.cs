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
	public partial class Form2 : Form
	{
		public List<string> Items = new List<string>();

		public Form2()
		{
			InitializeComponent();
		}

		public string ItemName
		{
			get { return Item_Name.Text; }
		}

		private void Item_Name_TextChanged(object sender, EventArgs e)
		{
			if (Item_Name.Text.Length > 0 && !Items.Contains(Item_Name.Text))
			{
				AddButton.Enabled = true;
			}
			else
			{
				AddButton.Enabled = false;
			}

			if (Items.Contains(Item_Name.Text))
			{
				Error_Item_Exist.SetError(Item_Name, "This item exit in your ToDo list!");
			}
			else
			{
				Error_Item_Exist.Clear();
			}
		}
	}
}
