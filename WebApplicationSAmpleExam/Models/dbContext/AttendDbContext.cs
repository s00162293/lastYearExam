﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationSAmpleExam.Models.dbContext
{
    public class AttendDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        public AttendDbContext()
            : base("DefaultConnection")
        {
        }

        public static AttendDbContext Create()
        {
            return new AttendDbContext();
        }

    }
}