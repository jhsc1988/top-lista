using Microsoft.AspNetCore.Identity;

namespace top_lista.Models
{
    public class AdminUserRoleInit
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin@localhost").Result == null)
            {
                IdentityUser user = new()
                {
                    UserName = "admin@localhost",
                    Email = "admin@localhost"
                };

                if (userManager.CreateAsync(user, "p@ssW0rd__").Result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {

            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new()
                {
                    Name = "Administrator"
                };
                _ = roleManager.CreateAsync(role);
            }
        }
    }
}
