﻿using bookly.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace bookly.Data
{
    public class AppDbContext: DbContext
    {
        protected readonly IConfiguration Configuration;


        public AppDbContext(IConfiguration configuration)
        {
            configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Book> Employees { get; set; } 
    }
}
