﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApiAuthentication.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }
    }
}
