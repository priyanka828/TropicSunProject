using Microsoft.EntityFrameworkCore;
using TropicSun.Models;

namespace TropicSun.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Insert sample Yacht Data
            modelBuilder.Entity<Yacht>()
               .ToTable("Yacht");
            modelBuilder.Entity<Yacht>()
               .Property(s => s.YachtId)
               .IsRequired(true);


            modelBuilder.Entity<Yacht>()
                .HasData(new Yacht { YachtId = 1},
                         new Yacht { YachtId = 2}
                         );
            //Insert sample Reservation Data
            modelBuilder.Entity<Reservation>()
                .ToTable("Reservation");
            modelBuilder.Entity<Reservation>()
               .Property(s => s.ReservationId)
               .IsRequired(true);
            modelBuilder.Entity<Reservation>()
                .Property(s => s.YachtId)
                .IsRequired(false);
            modelBuilder.Entity<Reservation>()
                .Property(s => s.ReservationDate);

            modelBuilder.Entity<Reservation>()
                .HasData(
                    new Reservation
                    {
                        ReservationId = 1,
                        YachtId = 1,
                        ReservationDate = DateTime.Now
                    }
                );

        }




    }
}
