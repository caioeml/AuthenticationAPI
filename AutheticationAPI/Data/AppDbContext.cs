using AutheticationAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutheticationAPI.Data
{
    public class AppDbContext(DbContextOptions options)
        : IdentityDbContext<User>(options);

}
