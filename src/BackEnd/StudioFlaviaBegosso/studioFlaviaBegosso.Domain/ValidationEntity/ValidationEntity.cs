using studioFlaviaBegosso.Domain.Model;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.ValidationEntity
{
    public static class ValidationEntity
    {
        #region[OnModelCreating]
        public static ModelBuilder ValidationEntitys(this ModelBuilder modelBuilder)
        {
            ValidationBlog(modelBuilder);
            ValidationWork(modelBuilder);
            ValidationGallery(modelBuilder);
            ValidationQuestionFrequent(modelBuilder);
            ValidationEmail(modelBuilder);
            ValidationClient(modelBuilder);
            ValidationMaintenance(modelBuilder);
            ValidationMaintenanceChoose(modelBuilder);
            ValidationProcedure(modelBuilder);
            ValidationScheduleClient(modelBuilder);
            ValidationScheduleClientHistory(modelBuilder);

            return modelBuilder;
        }

        private static void ValidationBlog(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogModel>()
                          .Property(p => p.Name)
                          .IsRequired();

            modelBuilder.Entity<BlogModel>()
               .Property(p => p.Description)
               .IsRequired();

            modelBuilder.Entity<BlogModel>()
                .Property(p => p.Image)
                .IsRequired();
        }

        private static void ValidationWork(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkModel>()
                          .Property(p => p.Name)
                          .IsRequired();

            modelBuilder.Entity<WorkModel>()
               .Property(p => p.Description)
               .IsRequired();

            modelBuilder.Entity<WorkModel>()
                .Property(p => p.Image)
                .IsRequired();
        }

        private static void ValidationGallery(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GalleryModel>()
                           .Property(p => p.Name)
                           .IsRequired();

            modelBuilder.Entity<GalleryModel>()
                .Property(p => p.Image)
                .IsRequired();
        }

        private static void ValidationQuestionFrequent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionFrequentModel>()
                            .Property(p => p.Name)
                            .IsRequired();

            modelBuilder.Entity<QuestionFrequentModel>()
                .Property(p => p.Description)
                .IsRequired();
        }

        private static void ValidationEmail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailModel>()
                           .Property(p => p.NameClient)
                           .IsRequired();

            modelBuilder.Entity<EmailModel>()
                          .Property(p => p.PhoneClient)
                          .IsRequired();

            modelBuilder.Entity<EmailModel>()
                          .Property(p => p.SubjectClient)
                          .IsRequired();

            modelBuilder.Entity<EmailModel>()
                .Property(p => p.DescriptionClient)
                .IsRequired();
        }

        private static void ValidationClient(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientModel>()
                          .Property(p => p.NameFull)
                          .IsRequired();

            modelBuilder.Entity<ClientModel>()
               .Property(p => p.City)
               .IsRequired();

            modelBuilder.Entity<ClientModel>()
                .Property(p => p.Age)
                .IsRequired();
        }

        private static void ValidationMaintenance(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaintenanceModel>()
                         .Property(p => p.Name)
                         .IsRequired();
        }

        private static void ValidationMaintenanceChoose(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaintenanceChooseModel>()
                         .Property(p => p.Name)
                         .IsRequired();
        }

        private static void ValidationProcedure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProcedureModel>()
                          .Property(p => p.Name)
                          .IsRequired();
        }

        private static void ValidationScheduleClient(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Client)
              .HasForeignKey<ScheduleClientModel>(ad => ad.ClientId);

            modelBuilder.Entity<ProcedureModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Procedure)
              .HasForeignKey<ScheduleClientModel>(ad => ad.ProcedureId);

            modelBuilder.Entity<MaintenanceModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Maintenance)
              .HasForeignKey<ScheduleClientModel>(ad => ad.MaintenanceId);

            modelBuilder.Entity<MaintenanceChooseModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.MaintenanceChoose)
              .HasForeignKey<ScheduleClientModel>(ad => ad.MaintenanceChooseId);
        }

        private static void ValidationScheduleClientHistory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Client)
              .HasForeignKey<ScheduleClientModel>(ad => ad.ClientId);

            modelBuilder.Entity<ProcedureModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Procedure)
              .HasForeignKey<ScheduleClientModel>(ad => ad.ProcedureId);

            modelBuilder.Entity<MaintenanceModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.Maintenance)
              .HasForeignKey<ScheduleClientModel>(ad => ad.MaintenanceId);

            modelBuilder.Entity<MaintenanceChooseModel>()
              .HasOne(s => s.ScheduleClient)
              .WithOne(ad => ad.MaintenanceChoose)
              .HasForeignKey<ScheduleClientModel>(ad => ad.MaintenanceChooseId);
        }
        #endregion[OnModelCreating]

        #region[ConfigureConventions]
        public static ModelConfigurationBuilder ConfigurationEntitys(this ModelConfigurationBuilder modelConfigurationBuilder)
        {
            modelConfigurationBuilder.Properties<string>().HaveMaxLength(1000);

            return modelConfigurationBuilder;
        }
        #endregion[ConfigureConventions]
    }
}
