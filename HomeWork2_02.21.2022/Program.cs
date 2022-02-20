using System;

namespace HomeWork2_02._21._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("sadigov","1234");
            //Console.WriteLine(user.GetInfo());

            Admin admin = new Admin("sadigov","12345",true,"add");
            Console.WriteLine(admin.getinfo());
        }
    }
}
