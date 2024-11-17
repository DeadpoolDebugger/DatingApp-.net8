using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data; // Updated the namespace to follow the appropriate structure. Changed namespace API to namespace API.Data

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; } = null!;
}