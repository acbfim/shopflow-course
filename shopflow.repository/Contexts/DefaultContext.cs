using Microsoft.EntityFrameworkCore;
using shopflow.contract.Model.Entities.Customer;

namespace shopflow.repository.Contexts
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> opt) : base(opt)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DocumentType>()
                .HasData(
                    new DocumentType { Id = 1, Name = "RG", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 2, Name = "CPF", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 3, Name = "CNPJ", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 4, Name = "CNH", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 5, Name = "Certidão de Nascimento", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 6, Name = "Certidão de Casamento", InternalProperty = true, IsActive = true },
                    new DocumentType { Id = 7, Name = "Foto do usuário", InternalProperty = true, IsActive = true }
                );

            modelBuilder.Entity<ContactType>()
                .HasData(
                    new ContactType { Id = 1, Name = "Celular", InternalProperty = true },
                    new ContactType { Id = 2, Name = "E-mail", InternalProperty = true },
                    new ContactType { Id = 3, Name = "Telegram", InternalProperty = true }
                );

        }

    }
}