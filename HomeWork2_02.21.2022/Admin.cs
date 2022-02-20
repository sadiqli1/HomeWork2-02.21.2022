using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2_02._21._2022
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username, string password, bool issuperadmin, string section) : base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        public string getinfo()
        {
            return GetInfo() + $"\nIsSuperAdmin:{IsSuperAdmin}\nSection:{Section}";
        }
    }
}
