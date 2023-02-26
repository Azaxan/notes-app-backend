using Microsoft.EntityFrameworkCore;

namespace notes_app_backend.Models.Entities
{
    public class MyNotesContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MyNotesContext(DbContextOptions<MyNotesContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(note =>
            {
                note.Property(n => n.Id).IsRequired();
                note.Property(n => n.Description).IsRequired();
                note.Property(n => n.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired();
            });
        }
    }
}
