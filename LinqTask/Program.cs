using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static List<Employee> employees = new List<Employee>
            {
                new Employee {EmployeeId=1,FirstName="John",LastName="Abraham",Salary=1000000, JoiningDate=new DateTime(2013, 1, 1),Department="Banking"},
                new Employee {EmployeeId=2,FirstName="Michael",LastName="Clarke",Salary=800000, JoiningDate=new DateTime(2013, 1, 1),Department="Insurance"},
                new Employee {EmployeeId=3,FirstName="Roy",LastName="Thomas",Salary=700000, JoiningDate=new DateTime(2013, 2, 1),Department="Banking"},
                new Employee {EmployeeId=4,FirstName="Tom",LastName="Jose",Salary=600000, JoiningDate=new DateTime(2015, 2, 1),Department="Insurance"},
                new Employee {EmployeeId=5,FirstName="Jerry",LastName="Pinto",Salary=650000, JoiningDate=new DateTime(2015, 2, 1),Department="Insurance"},
                new Employee {EmployeeId=6,FirstName="Philip",LastName="Pinto",Salary=750000, JoiningDate=new DateTime(2015, 1, 1),Department="Services"},
                new Employee {EmployeeId=7,FirstName="Manish",LastName="Parmar",Salary=650000, JoiningDate=new DateTime(2013, 1, 1),Department="Services"},
                new Employee {EmployeeId=8,FirstName="Chetan",LastName="Chauhan",Salary=600000, JoiningDate=new DateTime(2013, 2, 1),Department="Insurance"}

            };
        static List<Incentives> incentives = new List<Incentives>
            {
                new Incentives {EmployeeRefId=1,IncentiveDate=new DateTime(2013, 2, 1),IncentiveAmount=5000},
                new Incentives {EmployeeRefId=2,IncentiveDate=new DateTime(2013, 2, 1),IncentiveAmount=3000},
                new Incentives {EmployeeRefId=3,IncentiveDate=new DateTime(2013, 2, 1),IncentiveAmount=4000},
                new Incentives {EmployeeRefId=1,IncentiveDate=new DateTime(2013, 1, 1),IncentiveAmount=4500},
                new Incentives {EmployeeRefId=2,IncentiveDate=new DateTime(2013, 1, 1),IncentiveAmount=3500},


            };
        static void Main(string[] args)
        {
            Console.WriteLine("--- Get all employee details from the employee table----");
            IEnumerable<Employee> employeesquery = from emp in employees select emp;
            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.Salary} {emp.JoiningDate} {emp.Department}");
            }

            Console.WriteLine(" Get First_Name, Last_Name from employee table");
            IEnumerable<Employee> employeesquery1 = from emp in employees select emp;
            foreach (var emp in employeesquery1)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} ");
            }


            Console.WriteLine("Get First_Name from employee table using alias name “Employee Name”");
            var employeesquery2 =
                from emp in employees
                select new { EmplooyeeName = emp.FirstName };
            foreach (var emp in employeesquery2)
            {
                Console.WriteLine($"{emp.EmplooyeeName}   ");
            }


            Console.WriteLine("  Get First_Name from employee table in upper case");
            IEnumerable<Employee> employeesquery3 = from emp in employees select emp;

            foreach (var emp in employeesquery3)
            {
                Console.WriteLine($"{emp.FirstName.ToUpper()} ");
            }

            Console.WriteLine("  Get First_Name from employee table in lower case");
            IEnumerable<Employee> employeesquery4 = from emp in employees select emp;

            foreach (var emp in employeesquery4)
            {
                Console.WriteLine($"{emp.FirstName.ToLower()} ");
            }


            Console.WriteLine("Get unique DEPARTMENT from employee table");
            var employeesquery5 =
                (from emp in employees
                 select emp.Department).Distinct();

            foreach (var emp in employeesquery5)
            {
                Console.WriteLine($"{emp}  ");
            }
            Console.WriteLine("Get length of FIRST_NAME from employee table");
            IEnumerable<Employee> employeesquery6 = from emp in employees select emp;

            foreach (var emp in employeesquery6)
            {
                Console.WriteLine($"{emp.FirstName.Length} ");
            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
