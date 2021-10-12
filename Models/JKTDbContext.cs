using JinKeTang.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JinKeTang.Models
{
    public class JKTDbContext : DbContext
    {
        public JKTDbContext(DbContextOptions<JKTDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }

    }
}
