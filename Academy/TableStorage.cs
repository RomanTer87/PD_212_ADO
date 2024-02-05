using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	internal class TableStorage
	{
		SqlConnection connection;
		SqlDataAdapter adapter;
		DataSet set;
		SqlCommandBuilder builder;
		DataSet Set { get; }
		TableStorage()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			set = new DataSet();

		}
		public void GetDataFromBase(string table)
		{
			try
			{
				string cmd = $"SELECT * FROM {table}";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set,table);
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
