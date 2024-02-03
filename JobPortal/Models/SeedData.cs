using JobPortal.Models;
using Microsoft.EntityFrameworkCore;
using MvcJobPortal.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcJobPortalContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcJobPortalContext>>()))
        {
            // Look for any job.
            if (context.Jobs.Any())
            {
                return;   // DB has been seeded
            }
            context.Jobs.AddRange(
                new Jobs
                {
                    Company = "Google",
                    Position = "Software Engineer",
                    DatePosted = DateTime.Parse("2021-01-01"),
                    Location = "Mountain View, CA",
                    Salary = 120000
                },
                new Jobs {
                    Company = "Microsoft",
                    Position = "Software Engineer",
                    DatePosted = DateTime.Parse("2021-01-01"),
                    Location = "Redmond, WA",
                    Salary = 100000
                },
                new Jobs { 
                    Company = "Amazon",
                    Position = "Software Engineer",
                    DatePosted = DateTime.Parse("2021-01-01"),
                    Location = "Seattle, WA",
                    Salary = 110000
                },
                new Jobs
                {
                    Company = "Facebook",
                    Position = "Software Engineer",
                    DatePosted = DateTime.Parse("2021-01-01"),
                    Location = "Menlo Park, CA",
                    Salary = 115000
                }

            );
            context.SaveChanges();
        }
    }
}