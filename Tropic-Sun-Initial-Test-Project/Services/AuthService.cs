using System;
using Tropic_Sun_Initial_Test_Project.Data;
using Tropic_Sun_Initial_Test_Project.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tropic_Sun_Initial_Test_Project.Services
{
	public class AuthService
	{
		private Auth authData;
        public AuthService()
		{
			authData = new Auth();
        }

		public Tuple<SuccessDTO, int> SignIn(UserDTO user) {
            return this.authData.SignIn(user);
        }

        public SuccessDTO SignUp(UserDTO user)
        {
            return this.authData.SignUp(user);
        }
    }
}

