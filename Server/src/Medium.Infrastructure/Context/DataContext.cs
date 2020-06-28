﻿using Medium.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Medium.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Author> Authors { get; set; }
    }
}
