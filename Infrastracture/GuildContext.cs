using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture
{
    public class GuildContext:IdentityDbContext<IdentityUser>
    {
        public GuildContext(DbContextOptions<GuildContext> options) : base(options) { }
    }
}
