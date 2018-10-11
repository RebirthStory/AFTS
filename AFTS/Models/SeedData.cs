using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AFTS.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tennisContext(
                serviceProvider.GetRequiredService<DbContextOptions<tennisContext>>()))
            {
                

                context.Member.AddRange(
                     new Member
                     {
                         MemberId = 1,
                         Name = "admin",
                         Nickname = "admin",
                         Dob = DateTime.Parse("1991-01-01"),
                         Gender = "M",
                         Biography = "admin",
                         Email = "admin@admin.com",
                         Password = "admin",
                         RoleId = 1,

                     },

                     new Member
                     {
                         MemberId = 2,
                         Name = "coach",
                         Nickname = "coach",
                         Dob = DateTime.Parse("1991-01-01"),
                         Gender = "M",
                         Biography = "coach",
                         Email = "coach@coach.com",
                         Password = "coach",
                         RoleId = 2,
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
