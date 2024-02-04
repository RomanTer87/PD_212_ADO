using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	public partial class AddGroup : Form
	{
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;		//Вытягивает результаты запросов из базы, их сохраняет их в DataSet
		DataSet set;
		SqlCommandBuilder builder;
		public System.Windows.Forms.ComboBox CBDirection { get => cbDirections; }
		public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
		public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
		string[] week = new string [] { "Пн", "Вт", "Ср", "Чт", "Пт", "Cб", "Вс" };
		CheckBox[] cbWeek;
		public AddGroup()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			GetDataFromBase();
			//((Form1)Parent).LoadDataToComboBox(cbDirections, "Directions", "direction_name", "Выберите направление обучения");
			//((Form1)Parent).LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//((Form1)Parent).LoadDataToComboBox(cbTime, "LearningTimes", "form_name", "Выберите время обучения");
			cbWeek = new CheckBox[7];
		}
		void GetDataFromBase()
		{
			try
			{
				set = new DataSet();
				string cmd = $@"SELECT * FROM Directions";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set, "Directions");

				adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
				builder.DataAdapter = adapter;
				adapter.Fill(set, "LearningTimes");
			}
			catch(Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}
		string GenerateGroupName()
		{
			string group_name = "";
			if(cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				//if(cbDirections.SelectedItem.ToString() == "Разработка программного обеспечения")
				{
					if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += lcbWeek.SelectedItem.ToString();
					//DataRow[] rows = set.Tables["Directions"].Select("direction_name='Разработка программного обеспечения'");
					//DataRow row = rows[0];
					//group_name += row["direction_code_name"];
					group_name +=
						set.Tables["Directions"].Select($"direction_name='{cbDirections.SelectedItem.ToString()}'")[0]["direction_code_name"];
					group_name +=
						set.Tables["LearningTimes"].Select($"time_name='{CBLearningTime.SelectedItem.ToString()}'")[0]["time_code_name"];
				}
			}
			group_name += "_";
			return group_name;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			tbGroupName.Text = GenerateGroupName();
		}
	}
}
