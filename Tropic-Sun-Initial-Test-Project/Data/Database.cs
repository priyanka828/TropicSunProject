using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Tropic_Sun_Initial_Test_Project.Data
{
	public class Database
	{
		private static Database instance;
		SqlConnection conn;
		private Database()
		{
            string connString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["AZURE_SQL_CONNECTIONSTRING"];
            conn = new SqlConnection(connString);
        }

		public static Database getInstance()
		{
			if(instance == null)
			{
				instance = new Database();
				instance.createTables();
			}

			return instance;
		}
		

		public int ExecuteSQL(string cmd)
		{
			this.conn.Open();
            var command = new SqlCommand(cmd, conn);
			int r = command.ExecuteNonQuery();
			this.conn.Close();
			return r;
        }

        public SqlDataReader ExecuteReadSQL(string cmd)
        {
            this.conn.Open();
            var command = new SqlCommand(cmd, conn);
			SqlDataReader reader = command.ExecuteReader();

			return reader;
        }

		public void closeConn()
		{
			this.conn.Close();
		}

        private void createTables()
		{
			this.ExecuteSQL("IF ( NOT EXISTS (select object_id from sys.objects where object_id = OBJECT_ID(N'[dbo].[Authdata]') and type = 'U'))" +
				"BEGIN " +
				"CREATE TABLE Authdata (ID int NOT NULL PRIMARY KEY IDENTITY,Name varchar(255),Email varchar(255),Password varchar(255));" +
				"END");
		}
	}
}

