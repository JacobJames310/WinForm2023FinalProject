using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string userName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return String.Format($"{FirstName} {LastName}'s email is {Email} and their username is {UserName} and password is {Password} \n");
        }
    }
}
