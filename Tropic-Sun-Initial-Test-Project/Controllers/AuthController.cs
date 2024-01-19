using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tropic_Sun_Initial_Test_Project.Models;
using Tropic_Sun_Initial_Test_Project.Services;
using Tropic_Sun_Initial_Test_Project.DTO;

namespace Tropic_Sun_Initial_Test_Project.Controllers
{
    public class AuthController : Controller
    {
        AuthService authService = new AuthService();
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignInControl(SignInViewModel model)
        {

            UserDTO userDTO = new UserDTO();

            userDTO.email = model.email;
            userDTO.password = model.password;

            Tuple<SuccessDTO, int> result = this.authService.SignIn(userDTO);
            if (result.Item1.isSuccess)
            {
                return RedirectToAction("Index", "Home", new { Id = result.Item2 });

            }
            return SignIn();
        }

        [HttpPost]
        public IActionResult SignUpControl(SignUpViewModel model)
        {
            UserDTO userDTO = new UserDTO();

            userDTO.name = model.name;
            userDTO.email = model.email;
            userDTO.password = model.password;

            SuccessDTO res = authService.SignUp(userDTO);
            if(res.isSuccess)
            {
                return RedirectToAction("SignIn", "Auth");
            }
            return View();
        }
    }
}

