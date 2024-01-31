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
				adapter.SelectCommand.CommandText = $@"SELECT * FROM Times";
			}
			catch(Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}
		string GenerateGroupName()
		{
			string group_name = "";
			if(cbLearningForm.SelectedItem == "Стационар")
			{
				//if(cbDirections.SelectedItem == "Разработка программного обеспечения")group_name+=
			}

			return group_name;
		}
	
	}
}
