using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            /* IComparable  */

            #region IComparable

            //List<Employee> list = new List<Employee>();
            //list.Add(new Employee() { Name = "Steve", Salary = 10000 });
            //list.Add(new Employee() { Name = "Janet", Salary = 10000 });
            //list.Add(new Employee() { Name = "Andrew", Salary = 10000 });
            //list.Add(new Employee() { Name = "Bill", Salary = 500000 });
            //list.Add(new Employee() { Name = "Lucy", Salary = 8000 });

            //// Uses Employee.ToString
            ///*  Uses IComparable.CompareTo() */
            //list.Sort();

            //foreach (var element in list)
            //{
            //    Console.WriteLine(element);
            //}


            #endregion

            #region IEnumerator



            #endregion


            /* Override-Polymophism */

            #region Override-Polymophism
            //OverridedArray overridedArray = new OverridedArray();
            //overridedArray.Add("");
            //overridedArray.Add(12);
            //Console.WriteLine(overridedArray.Count);
            #endregion

            /* ImplementedIList_Polymophism */
            #region ImplementedIList_Polymophism

            //List<String> NameOfEmployee = new List<string>();
            //NameOfEmployee.Add("Anh Hung");
            //NameOfEmployee.Add("Anh Duong");
            //NameOfEmployee.Add("Hoa");

            //EmployeeList employeeList = new EmployeeList();
            //employeeList.EmployeeLists = NameOfEmployee;
            //foreach (var employee in employeeList)
            //{
            //    employee.GetType();
            //}
            //Console.WriteLine("List of Employees " + employeeList.EmployeeLists);

            #endregion
        }
    }
}
