﻿using System.ComponentModel.DataAnnotations;

namespace BookAPI.API.Models.User
{
    public class LoginUserDto
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
