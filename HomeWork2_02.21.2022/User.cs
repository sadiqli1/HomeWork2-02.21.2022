using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2_02._21._2022
{
    internal class User
    {
        
        private string Username 
        { 
            get 
            {
                return "10";
            }
            set 
            {
                while (Username.Length > 6)
                {
                    if (Username.Length > 6)
                    {
                        Username = Username;
                    }
                    else
                    {
                        Console.WriteLine("zehmet olmasa duzgun username daxil edin");
                        Username = Console.ReadLine();
                    }
                }
            }
        }
        private string Password;

        //private string Password 
        //{
        //    get 
        //    { 
        //        return Password;
        //    }
        //    set
        //    {
        //        if (Password==(1-9) && Password == (A-Z))
        //        {
        //            Console.WriteLine("zehmet olmasa duzgun password daxil edin");
        //            Password = Console.ReadLine();
        //        }
        //    } 
        //}
        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }

        public string GetInfo()
        {
            return $"Paswor:{Password}\nUsername:{Username}";
        }
    }
}
