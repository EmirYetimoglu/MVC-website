using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using _20051350008.Data;
using System;
using System.IO;

namespace _20051350008.Models
{
    public class DepartmentModel 
    {
        public Int32 ? Id { get; set; }
        public string DepartmentName { get; set; }
        public string ManagerName { get; set; }

        public DepartmentModel() 
        { 
        
        }

        public DepartmentModel(Int32 id, string DepartmentName, string ManagerName) 
        {
        //this.id = Id; 
        this.DepartmentName = DepartmentName;
        this.ManagerName = ManagerName;
        }
    }
    
}
