using Microsoft.EntityFrameworkCore;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.ValidationEntity;

namespace StudioFlaviaBegosso.Infra.Data.Context;

public class StudioFlaviaBegossoContext : DbContext
{
    public StudioFlaviaBegossoContext(DbContextOptions<StudioFlaviaBegossoContext> context) : base(context)
    {

    }

    public DbSet<QuestionFrequentModel> QuestionFrequents { get; set; }
    public DbSet<GalleryModel> Gallerys { get; set; }
    public DbSet<WorkModel> Works { get; set; }
    public DbSet<BlogModel> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ValidationEntitys();

    protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        => modelConfigurationBuilder.ConfigurationEntitys();
}
