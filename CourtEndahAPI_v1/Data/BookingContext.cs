using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourtEndahAPI_v1.DomainClasses;

namespace CourtEndahAPI_v1.Data
{
    public class BookingContext: DbContext
    {
        public BookingContext() {}

        public BookingContext(DbContextOptions<BookingContext> options) : base(options) {}

        public DbSet<BOOKING_T> BOOKING_Ts { get; set; }
        public DbSet<COURT_T> COURT_Ts { get; set; }
        public DbSet<PLAYER_T> PLAYER_Ts { get; set; }
        public DbSet<ADMIN_T> ADMIN_Ts { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOOKING_T>().HasKey(b => b.book_id);
            modelBuilder.Entity<COURT_T>().HasKey(c => c.court_id);
            modelBuilder.Entity<PLAYER_T>().HasKey(p => p.play_id);
            modelBuilder.Entity<ADMIN_T>().HasKey(a => a.admin_id);

            modelBuilder.Entity<PLAYER_T>().HasData(
                new PLAYER_T
                {
                    play_id = 1,
                    play_username = "lim@gmail.com",
                    play_password = "12345",
                    play_fullname = "lim",
                    play_unitno = "D1006",
                    play_cardno = "D3517",
                    play_createdate = DateTime.Now.ToString(),
                    play_active = 1
                },
                new PLAYER_T
                {
                    play_id = 2,
                    play_username = "choong@gmail.com",
                    play_password = "12345",
                    play_fullname = "choong",
                    play_unitno = "C163A",
                    play_cardno = "D4059",
                    play_createdate = DateTime.Now.ToString(),
                    play_active = 1
                }
            );

            modelBuilder.Entity<COURT_T>().HasData(
                new COURT_T
                {
                    court_id = 1,
                    court_type = "Court A",
                    court_active = 1
                },
                new COURT_T
                {
                    court_id = 2,
                    court_type = "Court B",
                    court_active = 1
                }
            );

            modelBuilder.Entity<ADMIN_T>().HasData(
                new ADMIN_T
                {
                    admin_id = 1,
                    admin_username = "admin",
                    admin_password = "12345"
                }
            );

        }

    }
}
