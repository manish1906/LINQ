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
                new Employee {EmployeeId=2,FirstName="Michael",LastName="Clarke",Salary=800000, JoiningDate=new DateTime(2013, 1, 20),Department="Insurance"},
                new Employee {EmployeeId=3,FirstName="Roy",LastName="Thomas",Salary=700000, JoiningDate=new DateTime(2013, 2, 1),Department="Banking"},
                new Employee {EmployeeId=4,FirstName="Tom",LastName="Jose",Salary=600000, JoiningDate=new DateTime(2015, 2, 1),Department="Insurance"},
                new Employee {EmployeeId=5,FirstName="Jerry",LastName="Pinto",Salary=650000, JoiningDate=new DateTime(2015, 2, 1),Department="Insurance"},
                new Employee {EmployeeId=6,FirstName="Philip",LastName="Pinto",Salary=750000, JoiningDate=new DateTime(2015, 1, 20),Department="Services"},
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
            
            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} ");
            }


            Console.WriteLine("Get First_Name from employee table using alias name “Employee Name”");
            var employeesquery1 =
                from emp in employees
                select new { EmplooyeeName = emp.FirstName };
            foreach (var emp in employeesquery1)
            {
                Console.WriteLine($"{emp.EmplooyeeName}   ");
            }


            Console.WriteLine("  Get First_Name from employee table in upper case");
          

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.ToUpper()} ");
            }

            Console.WriteLine("  Get First_Name from employee table in lower case");
            

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.ToLower()} ");
            }


            Console.WriteLine("Get unique DEPARTMENT from employee table");
            var employeesquery2 =
                (from emp in employees
                 select emp.Department).Distinct();

            foreach (var emp in employeesquery2)
            {
                Console.WriteLine($"{emp}  ");
            }
            Console.WriteLine("Get length of FIRST_NAME from employee table");
           

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.Length} ");
            }



            Console.WriteLine(" Select first 3 characters of FIRST_NAME from EMPLOYEE.");
           

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.Substring(0,3)} ");
            }

            Console.WriteLine("Get position of 'o' in name 'John' from employee table");
            IEnumerable<Employee> employeesquery3 = from emp in employees where emp.FirstName == "John" select emp;

            foreach (var emp in employeesquery3)
            {
                Console.WriteLine($"{emp.FirstName.IndexOf("o")} ");
            }


            Console.WriteLine("Get First_Name from employee table after replacing 'o' with '$'");
          

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.Replace("o","$")} ");
            }

            Console.WriteLine(" Get FIRST_NAME from employee table after removing white spaces from right side");
            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.TrimEnd()} ");
            }


            Console.WriteLine(" Get FIRST_NAME from employee table after removing white spaces from left side");
            foreach (var emp in employeesquery)
            {
                Console.WriteLine($"{emp.FirstName.TrimStart()} ");
            }
            
            Console.WriteLine("Get all employee details from the employee table order by First_Name Ascending");
            IEnumerable<Employee> employeesquery4 = from emp in employees
                                                    orderby emp.FirstName ascending
                                                    select emp;


            foreach (var emp in employeesquery4)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }

            Console.WriteLine("Get all employee details from the employee table order by First_Name descending");
            IEnumerable<Employee> employeesquery5 = from emp in employees
                                                    orderby emp.FirstName descending
                                                    select emp;


            foreach (var emp in employeesquery5)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }

            Console.WriteLine("Get all employee details from the employee table order by First_Name Ascending and Salary descending");
            IEnumerable<Employee> employeesquery6 = from emp in employees
                                                    orderby emp.FirstName ascending,emp.Salary descending
                                                    select emp;


            foreach (var emp in employeesquery6)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.Salary} ");
            }


            Console.WriteLine(" Get employee details from employee table whose employee name is “John”");
            IEnumerable<Employee> employeesquery7 = from emp in employees
                                                   where emp.FirstName=="John"
                                                    select emp;


            foreach (var emp in employeesquery7)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}  {emp.JoiningDate}    {emp.Salary} {emp.Department}");
            }


            Console.WriteLine(" Get employee details from employee table whose employee name is “John” and “Roy”");
            IEnumerable<Employee> employeesquery8 = from emp in employees
                                                    where emp.FirstName == "John" || emp.FirstName=="Roy"
                                                    select emp;


            foreach (var emp in employeesquery8)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}  {emp.JoiningDate}    {emp.Salary} {emp.Department}");
            }


            Console.WriteLine("Get employee details from employee table whose employee name are not “John” and “Roy”");
            IEnumerable<Employee> employeesquery9 = from emp in employees
                                                    where emp.FirstName != "John" && emp.FirstName != "Roy"
                                                    select emp;


            foreach (var emp in employeesquery9)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}  {emp.JoiningDate}    {emp.Salary} {emp.Department}");
            }

            Console.WriteLine(" Get employee details from employee table whose first name starts with 'J'");
        
            IEnumerable<Employee> employeesquery10 = from emp in employees
                                                     where emp.FirstName.StartsWith("J")
                                                     select emp;
            foreach (var emp in employeesquery10)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }


            Console.WriteLine("Get employee details from employee table whose first name contains 'o'");
            IEnumerable<Employee> employeesquery11 = from emp in employees
                                                     where emp.FirstName.Contains("o")
                                                     select emp;


            foreach (var emp in employeesquery11)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }

            Console.WriteLine("Get employee details from employee table whose first name ends with 'n'");
            IEnumerable<Employee> employeesquery12 = from emp in employees
                                                     where emp.FirstName.EndsWith("n")
                                                     select emp;


            foreach (var emp in employeesquery12)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }


            Console.WriteLine("Get employee details from employee table whose first name ends with 'n' and name contains 4 letters");
            IEnumerable<Employee> employeesquery13 = from emp in employees
                                                     where emp.FirstName.EndsWith("n") && emp.FirstName.Length==4
                                                     select emp;
            foreach (var emp in employeesquery13)
            {
                Console.WriteLine($"{emp.FirstName} ");
            }

            Console.WriteLine("Get employee details from employee table whose first name start with 'j' and name contains 4 letters");
            IEnumerable<Employee> employeesquery14 = from emp in employees
                                                     where emp.FirstName.StartsWith("J") && emp.FirstName.Length == 4
                                                     select emp;
            foreach (var emp in employeesquery14)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }

            Console.WriteLine("Get employee details from employee table whose Salary greater than 600000");
            IEnumerable<Employee> employeesquery15 = from emp in employees
                                                     where emp.Salary > 600000
                                                     select emp;


            foreach (var emp in employeesquery15)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.Salary}");
            }

            Console.WriteLine("Get employee details from employee table whose Salary less than 800000");
            IEnumerable<Employee> employeesquery16 = from emp in employees
                                                     where emp.Salary < 800000
                                                     select emp;


            foreach (var emp in employeesquery16)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.Salary}");
            }



            Console.WriteLine("Get employee details from employee table whose Salary between 500000 and 800000");
            IEnumerable<Employee> employeesquery17 = from emp in employees
                                                     where emp.Salary < 800000 && emp.Salary>500000                                                     select emp;


            foreach (var emp in employeesquery17)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.Salary}");
            }


            Console.WriteLine("Get employee details from employee table whose name is 'John' and 'Michael'");
            IEnumerable<Employee> employeesquery18 = from emp in employees
                                                     where emp.FirstName== "John" || emp.FirstName== "Michael"
                                                     select emp;


            foreach (var emp in employeesquery18)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.Salary} {emp.Department}");
            }


            Console.WriteLine("31. Get employee details from employee table whose joining year is “2013”'");
            IEnumerable<Employee> employeesquery19 = from emp in employees
                                                     where emp.JoiningDate.Year==2013
                                                     select emp;


            foreach (var emp in employeesquery19)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.JoiningDate}  {emp.Salary} {emp.Department}");
            }




            Console.WriteLine("Get employee details from employee table whose joining month is “January”");
            IEnumerable <Employee> employeesquery20 = from emp in employees
                                                     where emp.JoiningDate.Month == 1
                                                     select emp;


            foreach (var emp in employeesquery20)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.JoiningDate}  {emp.Salary} {emp.Department}");
            }



            Console.WriteLine("Get employee details from employee table who joined before January 31st 2013");
            IEnumerable<Employee> employeesquery21 = from emp in employees
                                                     let date= new DateTime(2013, 1, 31)
                                                     where emp.JoiningDate<date
                                                     select emp;


            foreach (var emp in employeesquery21)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.JoiningDate}  {emp.Salary} {emp.Department}");
            }


            Console.WriteLine("Get employee details from employee table who joined after January 31st 2013");
            IEnumerable<Employee> employeesquery22 = from emp in employees
                                                     let date = new DateTime(2013, 1, 31)
                                                     where emp.JoiningDate > date
                                                     select emp;


            foreach (var emp in employeesquery22)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName} {emp.JoiningDate}  {emp.Salary} {emp.Department}");
            }




            Console.WriteLine("Get Joining Date and Time from employee table");
           

            foreach (var emp in employeesquery)
            {
                Console.WriteLine($" {emp.JoiningDate}  ");
            }


            Console.WriteLine(" Get Joining Date,Time including milliseconds from employee table");


            foreach (var emp in employeesquery)
            {
                Console.WriteLine($" {emp.JoiningDate.Millisecond}  ");
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

}
