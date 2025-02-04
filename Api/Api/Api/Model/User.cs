﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Text.RegularExpressions;

#nullable disable

namespace Api.Model
{
    public partial class User
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] Password { get; set; }
        [Required]
        public string Username { get; set; }
    }

    public class UserDto
    {
        [Required]
        [StringValidator(InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\", MinLength = 2, MaxLength = 255)]
        public string Firstname { get; set; }
        [Required]
        [StringValidator(InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\", MinLength = 2, MaxLength = 255)]
        public string Lastname { get; set; }
        [Required]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$")]
        public string Email { get; set; }
        [Required]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)[A-Za-z\d@$!%#?&]{8,255}$")]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }

    }

    public class LogInModel
    {
        [Required]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$")]
        public string Email { get; set; }
        [Required]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)[A-Za-z\d@$!%#?&]{8,255}$")]
        public string Password { get; set; }
    }

}
