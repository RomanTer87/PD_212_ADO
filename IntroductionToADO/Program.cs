using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace IntroductionToADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD_212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string);	// Создаем соединение с сервером. При создании оно не активно.
			connection.Open();  // Открываем соединение, поскольку автоматически оно не открывается.

			//Вставка:
			//string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES ('Steven', 'Hawking')";
			string insert_string = @"INSERT INTO Books (author, title, pages) VALUES (3, 'Avatar', 800)";
			SqlCommand cmd = new SqlCommand(insert_string, connection);
			//cmd.ExecuteNonQuery(); //INSERT, UPDATE, DELETE

			//Выборка:
			string select_string = @"SELECT * FROM Authors";
			cmd.CommandText = select_string;

			SqlDataReader rdr = cmd.ExecuteReader();
			while(rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
			}


			connection.Close();	// Соединение обязательно нужно закрывать
		}
	}
}
