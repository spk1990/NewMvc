using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using NewsMvc.data;
using System;
using System.Linq;

namespace NewsMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NewsDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NewsDBContext>>()))
            {
                // Look for any report.

                if (!context.Report.Any())
                {
                    return;
                }
                return;   // DB has been seeded



            }
        }
    }
}