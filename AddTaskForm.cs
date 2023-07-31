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
	public partial class AddTaskForm : Form
	{
		public List<string> Tasks = new List<string>();

		public AddTaskForm(int maximum_task_name_length)
		{
			InitializeComponent();
			Item_Name.MaxLength = maximum_task_name_length;
		}

		public string TaskName
		{
			get { return Item_Name.Text; }
			set { Item_Name.Text = value; }
		}

		private void Item_Name_TextChanged(object sender, EventArgs e)
		{
			if (Item_Name.Text.Length > 0 && !Tasks.Contains(Item_Name.Text))
			{
				AddButton.Enabled = true;
			}
			else
			{
				AddButton.Enabled = false;
			}

			if (Tasks.Contains(Item_Name.Text))
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
