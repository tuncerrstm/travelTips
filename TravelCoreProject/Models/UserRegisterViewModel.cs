using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname!!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your username!!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your email!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password!!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter again your password!!")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

    }
}
