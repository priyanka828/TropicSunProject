using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tropic_Sun_Initial_Test_Project.Models;
using Tropic_Sun_Initial_Test_Project.Services;
using Tropic_Sun_Initial_Test_Project.DTO;

namespace Tropic_Sun_Initial_Test_Project.Controllers;

public class HomeController : Controller
{

    private UserService userService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        userService = new UserService();
    }

    public IActionResult Index(int id)
    {
        UserModel userModel = new UserModel();

        UserDTO dto = userService.getUserById(id);

        userModel.name = dto.name;
        userModel.email = dto.email;

        return View(userModel);
    }

    public IActionResult LogoutControl()
    {
        return RedirectToAction("SignIn", "Auth");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

