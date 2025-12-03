using System;
using Microsoft.EntityFrameworkCore;
using backend.Api.Models;

namespace backend.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Training> Trainings { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
