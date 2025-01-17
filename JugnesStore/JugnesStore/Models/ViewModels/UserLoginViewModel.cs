﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JugnesStore.Models.ViewModels
{
    public class UserLoginViewModel
    {
        [Display(Name = "Mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Password { get; set; }
    }
}