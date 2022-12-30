using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.ValidationEntity;

namespace StudioFlaviaBegosso.Infra.Data.Context;

public class StudioFlaviaBegossoContext : IdentityDbContext<IdentityUser>
{
    public StudioFlaviaBegossoContext(DbContextOptions<StudioFlaviaBegossoContext> context) : base(context)
    {

    }

    public DbSet<QuestionFrequentModel> QuestionFrequents { get; set; }
    public DbSet<GalleryModel> Gallerys { get; set; }
    public DbSet<WorkModel> Works { get; set; }
    public DbSet<BlogModel> Blogs { get; set; }
    public DbSet<EmailModel> Emails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ValidationEntitys();
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        => modelConfigurationBuilder.ConfigurationEntitys();
}
