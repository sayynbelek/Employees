using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        // поля данных
        protected BenefitPackage empBenefits = new BenefitPackage();
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string ssn;

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }
            
            public double ComputePayDeducation ()
            {
                return 125.0;
            }
        }

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeducation();
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        public int Age
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }
        
        public string Name
        { get
                {
                return empName;
            }
            set
                {
                if (value.Length > 15)
                    Console.WriteLine("error! name must be less than 16 characters!");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
        public float Pay
        {
            get
            {
                return currPay;
            }
            set
            {
                currPay = value;
            }
        }
    
        // contruct
        public Employee() { }
     
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = Age;
            currPay = pay;
        }

        public Employee(string name, int id, float pay, float currPay, string ssn) : this(name, id, pay)
        {
            this.currPay = currPay;
            this.ssn = ssn;
        }

        // metody
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
