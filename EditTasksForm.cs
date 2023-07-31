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
	public partial class EditTasksForm : Form
	{
		public List<string> TaskNames = new List<string>();

		int task_name_position_in_table = 0;
		int maximum_task_name_length;
		int offset = 5;

		public EditTasksForm(int _maximum_task_name_length)
		{
			InitializeComponent();
			maximum_task_name_length = _maximum_task_name_length;
		}

		public void GenerateTable()
		{
			TablePanel.Controls.Clear();

			for (int i = 0; i < TaskNames.Count; i++)
			{
				TextBox text = new TextBox()
				{
					Text = TaskNames[i],
					MaxLength = maximum_task_name_length,
					MinimumSize = new Size((maximum_task_name_length + offset) * 10, 20),
				};

				if (TablePanel.RowCount < i) TablePanel.RowCount += 1;

				TablePanel.Controls.Add(text, task_name_position_in_table, i);
			}
		}

		public List<string> Tasks
		{
			get { return TaskNames; }
			set { TaskNames = value; }
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < TaskNames.Count; i++)
			{
				TaskNames[i] = TablePanel.GetControlFromPosition(task_name_position_in_table, i).Text;
			}
		}
	}
}
