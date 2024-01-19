using System;
using Tropic_Sun_Initial_Test_Project.Data;
using Tropic_Sun_Initial_Test_Project.DTO;
namespace Tropic_Sun_Initial_Test_Project.Services;

public class UserService
{
	private User user;
	public UserService()
	{
		user = new User();
	}

	public UserDTO getUserById(int userId)
	{
		return this.user.getUserById(userId).Item2;
	}
}

