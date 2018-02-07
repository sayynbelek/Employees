using EmployeeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class BenefitPackage : Employee
    {
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
