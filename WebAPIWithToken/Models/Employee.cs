﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIWithToken.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
