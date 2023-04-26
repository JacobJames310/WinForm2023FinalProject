using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class CreateUser
    {
        public CreateUser(string username, string password, string email, string firstName, string lastName, string key)
        {
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Key = key;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Key { get; set; }
        public override string ToString()
        {
            return string.Format($"Welcome to TimeSheet {FirstName}! Your username will be {Username}, " +
                $"your password will be {Password}, we will send you a notification email at {Email} if " +
                $"you need to reset your password. The key for your company is {Key}.");
        }

    }
}
