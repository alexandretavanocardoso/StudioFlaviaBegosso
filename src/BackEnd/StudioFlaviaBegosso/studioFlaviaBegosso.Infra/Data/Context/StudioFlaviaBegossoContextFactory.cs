using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Context;

public class StudioFlaviaBegossoContextFactory : IDesignTimeDbContextFactory<StudioFlaviaBegossoContext>
{
    public StudioFlaviaBegossoContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StudioFlaviaBegossoContext>();
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-CNCGSRV;Initial Catalog=StudioFlaviaBegossoDb;Encrypt=False;Trusted_Connection=True;MultipleActiveResultSets=true");

        return new StudioFlaviaBegossoContext(optionsBuilder.Options);
    }
}
