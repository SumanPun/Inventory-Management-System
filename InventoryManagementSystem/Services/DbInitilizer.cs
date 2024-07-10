using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace InventoryManagementSystem.Services
{
    public class DbInitilizer
    {
        public static async Task SeedDataAsync(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, IServiceProvider serviceProvider)

        {
            if(userManager == null || roleManager == null)
            {
                return;
            }

            //create roles
            var roles = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Manager", "WarehouseStaff", "SalesStaff", "Supplier", "Viewer" };

            foreach (string roleName in roleNames)
            {
                var roleExist = await roles.RoleExistsAsync(roleName);
                if(!roleExist) 
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //create an admin user
            var adminUser = await userManager.GetUsersInRoleAsync("Admin");
            if (!adminUser.Any())
            {
                var user = new ApplicationUser()
                {
                    FullName = "Admin Admin",
                    Email = "admin@admin.com",
                    UserName = "admin@admin.com",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false,
                    DeletedAt = null
                };

                string defaultPassword = "Admin@123";
                var result = await userManager.CreateAsync(user,defaultPassword);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

        }
    }
}
