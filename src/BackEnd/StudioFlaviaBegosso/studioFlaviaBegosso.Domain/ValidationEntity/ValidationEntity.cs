using Microsoft.EntityFrameworkCore;
using studioFlaviaBegosso.Domain.Model;
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
                .Property(p => p.DescriptionClient)
                .IsRequired();
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
