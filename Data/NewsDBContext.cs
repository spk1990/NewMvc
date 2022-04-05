#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsMvc.Models;

    public class NewsDBContext : DbContext
    {
        public NewsDBContext (DbContextOptions<NewsDBContext> options)
            : base(options)
        {
        }

        public DbSet<NewsMvc.Models.Report> Report { get; set; }
    }
