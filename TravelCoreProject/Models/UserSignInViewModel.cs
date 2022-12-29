using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please enter username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }
    }
}
