﻿using Microsoft.EntityFrameworkCore;
using EMPApis.Models;


namespace EmployeeAPI.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> Employee { get; set; }
    }
}
