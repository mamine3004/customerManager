﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corelayer
{
    public class User
    {
        int id;
        string role;
        string name;
        string password;
        public int Id {  get => id; set=> id=value; }
        public string Name { get => name; set => name= value; }
        public string Password { get => password; set => password = value; }

        public string Role { get => role; set => role = value; }
        
    }
}
