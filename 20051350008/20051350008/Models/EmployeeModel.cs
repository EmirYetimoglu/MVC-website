using Microsoft.AspNetCore.Mvc;
using _20051350008.Models;
using System.Collections.Generic;

namespace _20051350008.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string IteamCode { get; set; }
        public double Price { get; set; }

        public static List<EmployeeModel> GetList()
        {
            List<EmployeeModel> Employees = new List<EmployeeModel>{
              new EmployeeModel   { Id="1", ProductName="Hammer", IteamCode="H12", Price=45000},
              new EmployeeModel   { Id="2",ProductName="Screwdriver", IteamCode="S13", Price=25000},
              new EmployeeModel   { Id="3",ProductName="Wrench", IteamCode="W14", Price=25000},
              new EmployeeModel   { Id="4",ProductName="Electric sander", IteamCode="E15", Price=35000},
              new EmployeeModel   { Id="5",ProductName="Power saw", IteamCode="P16", Price=125000}
            };
            return Employees;
        }

        public static EmployeeModel Get(int Id1)
        {

            List<EmployeeModel> Employees = GetList();

            foreach (EmployeeModel employee in Employees)
            {
                //Console.WriteLine(employee);
                if (employee.Id == Id1.ToString())
                {
                    return employee;
                }
            }
            return null;

        }
    }
}