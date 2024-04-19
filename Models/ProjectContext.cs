using Microsoft.EntityFrameworkCore;
using Models.Users.User;

namespace Models;

public class ProjectContext : DbContext
{
    public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options) { }

    public DbSet<User>? Users { get; set; }
}
