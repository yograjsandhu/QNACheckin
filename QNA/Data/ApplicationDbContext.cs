using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QNA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QNA.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Category> Categories { get; set; }



        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Answer>().ToTable("Answer");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Question>().ToTable("Question");

        }


    }
}
