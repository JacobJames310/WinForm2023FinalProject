using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Employee
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }

        public decimal HourlyPay { get; set; }
        
        public override string ToString()
        {
            return Username;
        }
    }
}
