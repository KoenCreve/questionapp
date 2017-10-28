using Microsoft.EntityFrameworkCore;
using QuestionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionApp.Data
{
    public class VraagContext: DbContext
    {
        public VraagContext(DbContextOptions<VraagContext> options) : base(options)
        { }

        public DbSet<Vraag> Vragen { get; set; }
        public DbSet<Leerkracht> Leerkachten { get; set; }
        public DbSet<Student> Studenten { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vraag>().ToTable("Vraag");
            modelBuilder.Entity<Leerkracht>().ToTable("Leerkracht");
            modelBuilder.Entity<Student>().ToTable("Student");

        }


    }
}
