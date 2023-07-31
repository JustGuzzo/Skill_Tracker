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
	public partial class MainForm : Form
	{
		public List<string> TasksNameList = new List<string>();

		List<int> TasksValueList = new List<int>();

		string default_save_path = Directory.GetCurrentDirectory() + "/data.st";

		string save_path;

		int maximum_progress_bar_value = 0;
		int task_button_position_in_table = 0;
		int minus_button_position_in_table = 1;
		int delete_task_button_position_in_table = 2;
		int progress_bar_position_in_table = 3;

		int maximum_task_name_length = 23;
		int offset = 5;

		public MainForm()
		{
			InitializeComponent();
			maximum_progress_bar_value = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

			ReadFile(default_save_path);

			saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
			saveFileDialog1.RestoreDirectory = openFileDialog1.RestoreDirectory = true;
		}

		private void GenerateNewTable()
		{
			TablePanel.Controls.Clear();

			for (int i = 0; i < TasksNameList.Count; i++)
			{
				Button button = new Button()
				{
					Text = TasksNameList[i],
					MinimumSize = new Size((maximum_task_name_length + offset) * 5, 20),
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
					Value = TasksValueList[i],
					MarqueeAnimationSpeed = 0,
					Size = new Size(500, 23),
					Maximum = maximum_progress_bar_value,
				};

				button.Click += new EventHandler(this.NameTaskButtonClick);
				button_minus.Click += new EventHandler(this.MinusTaskButtonClick);
				delete.Click += new EventHandler(this.DeleteItemButtonClick);

				if (TablePanel.RowCount < i) TablePanel.RowCount += 1;

				TablePanel.Controls.Add(button, task_button_position_in_table, i);
				var styles = TablePanel.ColumnStyles;
				styles[0].SizeType = SizeType.Absolute;
				styles[0].Width = (maximum_task_name_length + offset) * 5
					;
				TablePanel.Controls.Add(button_minus, minus_button_position_in_table, i);
				TablePanel.Controls.Add(delete, delete_task_button_position_in_table, i);
				TablePanel.Controls.Add(bar, progress_bar_position_in_table, i);
			}
		}

		private void NameTaskButtonClick(object sender, EventArgs e)
		{
			_TaskButtonClick(sender, 1);
		}

		private void MinusTaskButtonClick(object sender, EventArgs e)
		{
			_TaskButtonClick(sender, -1);
		}

		private void _TaskButtonClick(object sender, int value)
		{
			int row = GetButtonRowNumberInTable(sender);

			var bar = (ProgressBar)TablePanel.GetControlFromPosition(progress_bar_position_in_table, row);

			if (bar.Value < maximum_progress_bar_value && value > 0 ||
				bar.Value > 0 && value < 0)
			{
				bar.Value += value;
			}

			TasksValueList[row] = bar.Value;
		}

		private void DeleteItemButtonClick(object sender, EventArgs e)
		{
			int row = GetButtonRowNumberInTable(sender);

			TasksNameList.RemoveAt(row);
			TasksValueList.RemoveAt(row);

			GenerateNewTable();
		}

		private int GetButtonRowNumberInTable(object sender)
		{
			return TablePanel.GetRow((Button)sender);
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

					TasksNameList.Add(name_text);
					TasksValueList.Add(number);
				}

				GenerateNewTable();
			}
		}

		private void addNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddTaskForm popup_window = new AddTaskForm(maximum_task_name_length);
			popup_window.Tasks = TasksNameList;

			if (popup_window.ShowDialog() == DialogResult.OK)
			{
				string item_name = popup_window.TaskName;
				if (!TasksNameList.Contains(item_name))
				{
					TasksNameList.Add(item_name);
					TasksValueList.Add(0);
				}

				GenerateNewTable();
			}
		}

		private void save_Click(object sender, EventArgs e)
		{
			string data = "";
			for (int i = 0; i < TasksNameList.Count; i++)
			{
				string line = TasksNameList[i].ToString() + ":" + TasksValueList[i].ToString() + "\n";

				data += line;
			}

			File.WriteAllText(default_save_path, data);
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult _ = saveFileDialog1.ShowDialog();
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			string path = saveFileDialog1.FileName;

			string data = "";
			for (int i = 0; i < TasksNameList.Count; i++)
			{
				string line = TasksNameList[i].ToString() + ":" + TasksValueList[i].ToString() + "\n";

				data += line;
			}

			File.WriteAllText(path, data);
		}

		private void openAnotherTaskListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult _ = openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			TasksNameList.Clear();
			TasksValueList.Clear();

			string path = openFileDialog1.FileName;
			ReadFile(path);
		}

		private void editTasksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditTasksForm popup_window = new EditTasksForm(maximum_task_name_length);
			popup_window.TaskNames = TasksNameList;
			popup_window.GenerateTable();

			if (popup_window.ShowDialog() == DialogResult.OK)
			{
				TasksNameList = popup_window.TaskNames;
				GenerateNewTable();
			}
		}
	}
}
