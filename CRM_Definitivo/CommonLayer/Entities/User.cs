﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public string LastName {  get; set; }
        public DateTime Birthdate {  get; set; }
        public string NumberPhone { get; set; }
        public string Passworduser { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Statususer { get; set; }
        public DateTime DateRegistration { get; set; }


    }
}