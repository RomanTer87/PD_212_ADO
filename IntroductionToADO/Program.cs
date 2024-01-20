using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net.Configuration;

namespace IntroductionToADO
{
	internal class Program
	{
		const string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD_212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		static void Main(string[] args)
		{
			//SqlConnection connection = new SqlConnection(connection_string);	// Создаем соединение с сервером. При создании оно не активно.
			//connection.Open();  // Открываем соединение, поскольку автоматически оно не открывается.

			////Вставка:
			////string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES ('Steven', 'Hawking')";
			//string insert_string = @"INSERT INTO Books (author, title, pages) VALUES (3, 'Avatar', 800)";
			//SqlCommand cmd = new SqlCommand(insert_string, connection);
			////cmd.ExecuteNonQuery(); //INSERT, UPDATE, DELETE

			////Выборка:
			//string select_string = @"SELECT * FROM Authors";
			//cmd.CommandText = select_string;
			//SqlDataReader rdr = cmd.ExecuteReader();
			//while(rdr.Read())
			//{
			//	Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
			//}
			//connection.Close();	// Соединение обязательно нужно закрывать

			AddAuthorConsole();
			AddBookConsole();
		}
		public static void AddAuthor(string first_name, string last_name)
		{
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			string insert_string = "INSERT INTO Authors (first_name, last_name) VALUES (@first_name, @last_name)";
			SqlCommand cmd = new SqlCommand(insert_string, connection);
			cmd.Parameters.AddWithValue("@first_name", first_name);
			cmd.Parameters.AddWithValue("@last_name", last_name);
			cmd.ExecuteNonQuery();
			Console.WriteLine("Автор успешно добавлен в базу данных");
			connection.Close();
		}
		public static void AddAuthorConsole()
		{
			Console.WriteLine("Введите имя автора:");
			string first_name = Console.ReadLine();
			Console.WriteLine("Введите фамилию автора:");
			string last_name = Console.ReadLine();
			AddAuthor(first_name, last_name);
		}
		public static void AddBook(int author, string title, int pages)
		{
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			string insert_string = "INSERT INTO Books (author,title,pages) VALUES (@author, @title, @pages)";
			SqlCommand cmd = new SqlCommand(insert_string, connection);
			cmd.Parameters.AddWithValue("@author", author);
			cmd.Parameters.AddWithValue("@title", title);
			cmd.Parameters.AddWithValue("@pages", pages);
			cmd.ExecuteNonQuery();
			Console.WriteLine("Книга успешно добавлена в базу данных");
			connection.Close();
		}
		public static void AddBookConsole()
		{
			PrintAuthor();
			Console.WriteLine("Введите Id автора:");
			int author = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите название книги:");
			string title = Console.ReadLine();
			Console.WriteLine("Введите количество страниц:");
			int pages = Convert.ToInt32(Console.ReadLine());
			AddBook(author, title, pages);
			Print();
		}
		public static void Print()
		{
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			string query = @"SELECT * FROM Authors, Book WHERE Authors.id = Books.author";
			SqlCommand cmd = new SqlCommand(query, connection);
			SqlDataReader reader = cmd.ExecuteReader();
			while(reader.Read())
			{
				Console.WriteLine($"Автор: {reader[1]} {reader[2]}, Книга: {reader[5]}, Страниц: {reader[6]}");
			}
			reader.Close();
			connection.Close();
		}
		public static void PrintAuthor()
		{
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			string query = @"SELECT * FROM Authors";
			SqlCommand cmd = new SqlCommand(query, connection);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine($"Id: {reader[0]}, Автор: {reader[1]} {reader[2]}");
			}
			reader.Close();
			connection.Close();
		}
	}
}
