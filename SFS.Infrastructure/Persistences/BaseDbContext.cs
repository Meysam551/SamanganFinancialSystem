
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SFS.Domain.Entities;

namespace SFS.Infrastructure;

public class BaseDbContext : IdentityDbContext<ApplicationUser, AppRole, Guid>
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }
}
