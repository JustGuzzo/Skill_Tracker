using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skill_Tracker
{
	internal class TaskData
	{
		public TaskData(string _name, int _value)
		{
			Name = _name;
			Value = _value;
		}

		public TaskData()
		{
			Name = defaultName;
			Value = defaultValue;
		}

		public string	Name;
		public int		Value;

		public const string	defaultName = "";
		public const int	defaultValue = -1;
	}

	internal class JSONFileManager
	{
		string file_path;
		List<TaskData> Tasks = new List<TaskData>();
		public JSONFileManager(string _path)
		{
			file_path = _path;
		}

		public List<TaskData> LoadTasksFromFile()
		{
			if (File.Exists(file_path))
			{
				string data = File.ReadAllText(file_path);

				JObject json_data = JObject.Parse(data);

				for (int i = 0; i < json_data["TASKS"].Count(); i++)
				{
					//if (json_data["TASKS"][i]["example"] != null) json_data["TASKS"][i]["ES"].ToString();
					
					// Name and Value are names of class variables
					string name = json_data["TASKS"][i]["Name"].ToString();
					int value = (int)json_data["TASKS"][i]["Value"];

					TaskData task = new TaskData(name, value);

					Tasks.Add(task);
				}

				return Tasks;
			}

			return null;
		}

		public void SaveTasksToFile(List<TaskData> _data)
		{
			Tasks = _data;

			string json_data = "{ \"TASKS\": " + JsonConvert.SerializeObject(Tasks) + "}";
			File.WriteAllText(file_path, json_data);
		}
	}
}
