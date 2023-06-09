﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class CreateUserContext : DbContext
    {
        
        public DbSet<CreateUser> CreateUser { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=RegisteredUsers; Trusted_Connection=True; MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreateUser>().HasData(
                new CreateUser { CreateUserId = "Jacobjames310", Password = "jjames339", FirstName = "Jacob", LastName = "James", Email = "jacobjames339@yahoo.com", CompanyName = "James Trucking",   },
                new CreateUser { CreateUserId = "Roshellec494", Password = "rchen191", FirstName = "Roshelle", LastName = "Chen", Email = "rchen1020@gmail.com", CompanyName = "Chen Publishing",   },
                new CreateUser { CreateUserId = "NyckJ111", Password = "njohnson220", FirstName = "Nyck", LastName = "Johnson", Email = "njohnson104@yahoo.com", CompanyName = "Johnson Ice-Cream",  }
                );
        } 
        
    }
}
