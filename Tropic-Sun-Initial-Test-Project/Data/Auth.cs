using System;
using Tropic_Sun_Initial_Test_Project.Data;
using Tropic_Sun_Initial_Test_Project.DTO;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Tropic_Sun_Initial_Test_Project.Data
{
	public class Auth
	{
		Database database;

		public Auth()
		{
			database = Database.getInstance();
		}

		public SuccessDTO SignUp(UserDTO user)
		{
			int res = this.database.ExecuteSQL("INSERT INTO [dbo].[Authdata] (Name, Email, Password)" +
				"VALUES ('" + user.name + "', '" + user.email + "', '" + user.password + "');");
			return new SuccessDTO(res > 0);
		}

		public Tuple<SuccessDTO, int> SignIn(UserDTO user)
        {
			SuccessDTO dto = new SuccessDTO(false);
            SqlDataReader rdr = this.database.ExecuteReadSQL("SELECT *" +
				"from [dbo].[Authdata] where (email='"+ user.email+"' and password ='"+ user.password+"')");
			int results = -1;
			if (rdr.HasRows)
			{
				rdr.Read();
                results = rdr.GetInt32(0);
				dto.isSuccess = true;
            }
			this.database.closeConn();
			return Tuple.Create(dto, results);
        }
    }
}

