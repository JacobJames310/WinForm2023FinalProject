using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
   
    public class Employee
    {
        private string _companyName;
        private List<Employee> _employees;

        public Employee() { }
        public Employee(string companyName, List<Employee> employees)
        {
            _companyName = companyName;
            _employees = employees;
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public List<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }
    }
}
