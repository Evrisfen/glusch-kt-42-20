﻿using Microsoft.EntityFrameworkCore;
using gluschKt_42_20.Model;
using gluschKt_42_20.Database.Configurations;

namespace gluschKt_42_20.Database
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Student {get;set;}
        public DbSet<Group> Group { get;set;}
        public DbSet<Subject> Subject { get;set;}

        DbSet<Grade> Grade { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        modelBuilder.ApplyConfiguration(new GradeConfiguration());
        }
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) 
        {
        }
    }
}
