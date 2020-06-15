using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MVC_ComicBooksCharacters.Models
{
    public class ComicBookContext : DbContext
    {
        public ComicBookContext(DbContextOptions<ComicBookContext> options) : base(options)
        {}

        public DbSet<ComicBook> ComicBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //Configuration.GetConnectionString("BloggingDatabase");
            string path = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDBFilename="
                + path + "\\comicbooks.mdf; Trusted_Connection=true;MultipleActiveResultSets=true";


            builder.UseSqlServer(conn);
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ComicBook>(entity =>
            //{
            //    entity.HasIndex(e => e.ComicBookID)
            //        .HasName("IndexComicBookID");

            //    entity.Property(e => e.ComicBookTitle)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});
            
        }
        
    }

}
