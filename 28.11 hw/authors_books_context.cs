using Microsoft.EntityFrameworkCore;

namespace hw
{
    public partial class AuthorsBooksDbContext : DbContext
    {
        public AuthorsBooksDbContext()
        {
        }
        
        public AuthorsBooksDbContext(DbContextOptions<AuthorsBooksDbContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-IB673J5\\SQLEXPRESS;" +
                    "Database=AuthorsBooksDB;" +
                    "Trusted_Connection=True;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=True;"
                );
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Authors");
                
                entity.HasKey(e => e.AuthorId);

                entity.Property(e => e.AuthorId)
                    .HasColumnName("Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });
            
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");

                entity.HasKey(e => e.BookId);
                
                entity.Property(e => e.BookId)
                    .HasColumnName("Id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
                
                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Authors");
            });
        }
    }
}