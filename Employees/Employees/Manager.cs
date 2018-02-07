using EmployeeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        private static float empID;
        public Manager() { }

        public int StockOptions
        {
            get; set;
        }
        public Manager (string fullName, int age, int enpID, float currPay,
            string ssn, int numbOfOpts)
            :base (fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }
    }
}
