using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public static class SeedData
    {
        public static async Task<int> EnsurePopulated(this IApplicationBuilder app)
        {
            var newsDbContext = app.ApplicationServices.GetService<NewsDbContext>();


            if (newsDbContext.Database.GetPendingMigrations().Any())
            {
                newsDbContext.Database.Migrate();
                newsDbContext.Database.EnsureCreated();
            }
            if (!newsDbContext.News.Any())
            {
                newsDbContext.News.AddRange(
                        new News
                        {
                            Title = "Haber Bir",
                            SubTitle = "ALT BASLIK 1",
                            Description = "BURSA",
                            Href = "https://www.casper.com.tr/uploads/2021/02/excalibur-wallpaper-06.jpg"
                        },
                        new News
                        {
                            Title = "Haber İki",
                            SubTitle = "ALT BASLIK 2",
                            Description = "İSTANBUL",
                            Href = "https://forum.donanimarsivi.com/attachments/bf82f6956a32819af48c2572243e8286-jpg.40997/"
                        },
                        new News
                        {
                            Title = "Haber Üc",
                            SubTitle = "ALT BASLIK 3",
                            Description = "İZMİR",
                            Href = "https://c4.wallpaperflare.com/wallpaper/500/442/354/outrun-vaporwave-hd-wallpaper-preview.jpg"
                        }
                    );
                newsDbContext.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole
                {
                    Id = new Guid().ToString(),
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = "Admin"
                });
            }
            var rowAffected = await newsDbContext.SaveChangesAsync();

            var userManager = app.ApplicationServices.GetService<UserManager<IdentityUser>>();
            IdentityUser user = new IdentityUser
            {
                UserName = "huseyin",
                NormalizedEmail = "huseyin",
                SecurityStamp = "HuseyinCumali",
                AccessFailedCount = 0,
                NormalizedUserName = "huseyin",
                Email = "huseyin@gmail.com",
                PhoneNumber = "05126578450"
            };

            var result = await userManager.CreateAsync(user, "cumali123");
            var resultRole = await userManager.AddToRoleAsync(user, "Admin");
            return rowAffected;

        }
    }
}
