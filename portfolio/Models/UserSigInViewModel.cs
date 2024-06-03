﻿using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class UserSigInViewModel
    {
        [Required(ErrorMessage = "Lütefen Kullanıcı adınızı giriniz*")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Lütefen şifrenizi giriniz*")]
        public string? Password { get; set; }
    }
}
