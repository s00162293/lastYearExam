namespace WebApplicationSAmpleExam.Migrations.attendDb
{
    using Models.dbContext;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationSAmpleExam.Models.dbContext.AttendDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\attendDb";
        }

        protected override void Seed(WebApplicationSAmpleExam.Models.dbContext.AttendDbContext context)
        {
          //  SeedSubjects(context);
            SeedAttendance(context);

        }

        private void SeedAttendance(AttendDbContext context)
        {
            //private List<Student>
            context.Attendances.AddOrUpdate(a => a.AttendanceID,
                new Attendance
                {
                    AttendanceDate = DateTime.Now,
                    Present = true,
                    StudentID = 1,
                    SubjectID = 1,
                });
            context.Attendances.AddOrUpdate(a => a.AttendanceID,
                new Attendance
                {
                    AttendanceDate = DateTime.Now,
                    Present = true,
                    StudentID = 2,
                    SubjectID = 2,
                });
        }

        private void SeedSubjects(AttendDbContext context)
        {
            context.Subjects.AddOrUpdate(s => s.SubjectID,
              new Subject
              {
                  SubjectName = "Calculus",
                  students = new List<Student> {
                                new Student { FirstName = "Mary", SecondName = "Jane" },
                                new Student { FirstName = "Boby", SecondName = "Bobberson" },
                           },
                  lecturers = new List<Lecturer>
                           {
                                new Lecturer { LecturerName = "Professor X" }
                           }
              }
           );

            context.Subjects.AddOrUpdate(s => s.SubjectID,
               new Subject
               {
                   SubjectName = "Algebra",
                   students = new List<Student> {
                                        new Student { FirstName = "Catherine", SecondName = "Janeway" },
                                        new Student { FirstName = "Jean-Luc", SecondName = "Picard" },
                                                    },
                   lecturers = new List<Lecturer> {
                                        new Lecturer { LecturerName = "Professor Snake" }
                                }
               }
            );


            context.Subjects.AddOrUpdate(s => s.SubjectID,
               new Subject
               {
                   SubjectName = "Trigonometry",
                   students = new List<Student> {
                                            new Student { FirstName = "Axl", SecondName = "Rose" }
                            }
               }
            );


            context.Subjects.AddOrUpdate(s => s.SubjectID,
               new Subject
               {
                   SubjectName = "Calculus"
               }
            );
        }

    }
}
