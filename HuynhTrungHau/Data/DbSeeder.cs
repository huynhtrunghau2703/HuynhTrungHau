using Microsoft.AspNetCore.Identity;
using HuynhTrungHau.Constants;
namespace HuynhTrungHau.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var useMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<UserManager<IdentityRole>>();

            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));


            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };

            var userIndb = await useMgr.FindByEmailAsync(admin.Email);
            if (userIndb is  null)
            {
                await useMgr.CreateAsync(admin, "admin@123");
                await useMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }
}
