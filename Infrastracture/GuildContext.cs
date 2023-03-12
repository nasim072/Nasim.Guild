using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture;

public class GuildContext : IdentityDbContext<IdentityUser>
{
    public GuildContext(DbContextOptions<GuildContext> options) : base(options) { }
}