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
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class AddGroup : Form
	{
	Form1 mainForm;
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
		public AddGroup(Form1 mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			GetDataFromBase();
			mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//mainForm.LoadDataToComboBox(cbDirections, "Directions", "direction_name", "Выберите направление обучения");
			mainForm.LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
			cbWeek = new CheckBox[7];

		}
		byte GetBitSet()
		{
			byte days = 0;
			#region PrintInConsole
			//AllocConsole();
			//Console.Write("Days:\t");
			//for(int i=0;i<clbWeek.CheckedItems.Count;i++)
			//{
			//	Console.Write(clbWeek.CheckedItems[i]+"\t");
			//}
			//Console.WriteLine();
			//Console.Write("Nums:\t");
			//for(int i = 0; i < clbWeek.CheckedIndices.Count; i++)
			//{
			//	Console.Write(clbWeek.CheckedIndices[i]+"\t");
			//}
			//Console.WriteLine();
			//Console.WriteLine("\n--------------------------------------------------\n"); 
			#endregion

			for(int i=0;i<clbWeek.CheckedIndices.Count;i++)
			{
				//byte day = (byte)Math.Pow(2, clbWeek.CheckedIndices[i]);
				//days += day;
				byte day = 1;
				day <<= clbWeek.CheckedIndices[i];
				days|= day;
				/*
				 ---------------------------------------------------------------

				<<  (побитовый сдвиг в лево) - это бинарный оператор, который сдвигает число на заданное количество бит в лево.
											   Свдиг числа на 1 бит влево увеличивает число в два раза (выполняет умножение числа на 2)
											   Свдиг числа на 2 бита влево увеличивает число в четыре раза (выполняет умножение числа на 4)
											   Свдиг числа на 3 бита влево увеличивает число в восемь раз (выполняет умножение числа на 8)

				| (побитовое сложение, побитовый OR) - если соответсвтующий бит хотя бы в одном операнде равен == 1. то этот же бит результата будет 1.

				Все побитовые операторы можно комбинировать с оператором присваивания.
				 ---------------------------------------------------------------
				 */
			}

			return days;
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
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
			//if (cbLearningForm.SelectedIndex == 0) return "Выберите форму обучения";
			//if (cbDirections.SelectedItem == null || cbDirections.SelectedItem.ToString() == "Выберите направление обучения") return "Выберите направление обучения";
			//if (cbTime.SelectedIndex == 0) return "Выберите время обучения";
			if (!AllCombosOk()) return "Что-то пошло не так";
			string group_name = "";
			if(cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				//if(cbDirections.SelectedItem.ToString() == "Разработка программного обеспечения")
				{
					if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += clbWeek.SelectedItem.ToString() == "Сб" ? "S": "V";
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

		private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			//			mainForm.LoadDataToComboBox
			//				(
			//				cbDirections,
			//				"Directions, LearningForms, LearningFormsDirectionsRelation",
			//				"direction_name",
			//				"Выберите форму обучения",
			//				$@"
			//WHERE	 LearningFormsDirectionsRelation.learning_form=LearningForms.form_id
			//AND		 LearningFormsDirectionsRelation.direction=Directions.direction_id
			//AND		 form_name = {CBLearningForm.SelectedItem.ToString()}
			//"
			//				);
			int selectedIndexInDirection = cbDirections.SelectedIndex;
			cbDirections.Items.Clear();
			if(cbLearningForm.SelectedIndex!=0)
			mainForm.LoadDataFromStorageToComboBox
							(
							cbDirections,
							"Directions, LearningForms, LearningFormsDirectionsRelation",
							"direction_name",
							"Выберите форму обучения",
							$@"
		 LearningFormsDirectionsRelation.learning_form=LearningForms.form_id
AND		 LearningFormsDirectionsRelation.direction=Directions.direction_id
AND		 form_name = '{CBLearningForm.SelectedItem.ToString()}'
"
							);
			//cbDirections.SelectedIndex = selectedIndexInDirection < cbDirections.Items.Count ? selectedIndexInDirection : -1;
			if(selectedIndexInDirection<cbDirections.Items.Count)
			{
				cbDirections.SelectedIndex = selectedIndexInDirection;
			}
			else
			{
				cbDirections.SelectedIndex = -1;
				cbDirections.Text = "выберите направление обучения";
				MessageBox.Show(this, "На данной форме обучения нет такого направления", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbDirections.Select();
			}
		}

		private void clbWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLearningDaysCode.Text = $"Дни обучения: {GetBitSet()}";
		}
		bool ComboBoxOk(ComboBox comboBox)
		{
			if (comboBox.SelectedItem == null) return false;
			if (comboBox.SelectedItem.ToString().Contains(" обучения")) return false;
			return true;
		}
		bool AllCombosOk()
		{
			string message = "";
			if (cbLearningForm.SelectedItem.ToString() == "Выберите форму обучения") message = "Выберите форму обучения";
			else if (cbDirections.SelectedItem == null || cbDirections.SelectedItem.ToString() == "Выберите направление обучения") message = "Выберите направление обучения";
			else if (cbTime.SelectedItem.ToString() == "Выберите время обучения") message = "Выберите время обучения";
			if(message.Length>0)
			{
				MessageBox.Show(this, message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void btnCreateGroup_Click(object sender, EventArgs e)
		{
			if(AllCombosOk() == false) return;
			//if  (
			//	!ComboBoxOk(cbLearningForm) && 
			//	!ComboBoxOk(cbDirections) &
			//	!ComboBoxOk(cbTime)
			//	)
			//{
			//	MessageBox.Show(this, "Ничего не выбрано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
			bool wrong_days = false;
			if (cbLearningForm.SelectedItem.ToString() == "Стационар" && clbWeek.CheckedItems.Count != 3) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Полустационар" && clbWeek.CheckedItems.Count != 1) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы" && clbWeek.CheckedItems.Count != 2) wrong_days = true;
			if (wrong_days) MessageBox.Show(this, "Проверьте дни обучения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else MessageBox.Show(this, "Все хорошо ;-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (wrong_days) return;

			TableStorage storage = new TableStorage();
			storage.GetDataFromBase("Directions");
			storage.GetDataFromBase("LearningTimes");
			storage.GetDataFromBase("Groups");
			//string insert_cmd = $@"
			//	INSERT INTO Groups(group_name, direction, learning_time, learning_days)
			//	VALUES (
			//	'{tbGroupName.Text}',
			//	{set.Tables["Directions"].Select($"direction_name='{cbDirections.SelectedItem.ToString()}'")[0]["direction_id"]},
			//	{set.Tables["LearningTimes"].Select($"time_name='{cbTime.SelectedItem.ToString()}'")[0]["time_id"]},
			//	{GetBitSet()}
			//	)";
			////storage.Adapter.InsertCommand.ExecuteNonQuery();
			//storage.Insert(insert_cmd);

			if (storage.Set.Tables["Groups"].Select($"group_name = '{tbGroupName.Text}'").Length == 0)
			{
				DataRow row = storage.Set.Tables["Groups"].NewRow();
				row["group_name"] = tbGroupName.Text;
				row["direction"] = storage.Set.Tables["Directions"].Select($"direction_name='{cbDirections.SelectedItem.ToString()}'")[0]["direction_id"];
				row["learning_time"] = storage.Set.Tables["LearningTimes"].Select($"time_name='{cbTime.SelectedItem.ToString()}'")[0]["time_id"];
				row["learning_days"] = GetBitSet();
				storage.Set.Tables["Groups"].Rows.Add(row);
				storage.Adapter.Update(storage.Set, "Groups"); 
			this.Close();
			}
			else
			{
				MessageBox.Show(this, "Такая группа уже есть", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}
	
	}
}
