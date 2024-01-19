using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Tropic_Sun_Initial_Test_Project.DTO;

namespace Tropic_Sun_Initial_Test_Project.Data
{
	public class User
	{
        Database database;
        public User()
		{
            database = Database.getInstance();
        }

        public Tuple<SuccessDTO, UserDTO> getUserById(int userId)
        {
            SuccessDTO success = new SuccessDTO(false);
            UserDTO user = new UserDTO();

            SqlDataReader rdr = this.database.ExecuteReadSQL("SELEct * from [dbo].[Authdata] where ID="+userId+"");

            if (rdr.HasRows)
            {
                rdr.Read();
                success.isSuccess = true;
                user.email = rdr.GetString("Email");
                user.name = rdr.GetString("Name");
            }
            this.database.closeConn();
            return Tuple.Create(success, user);
        }
    }
}

