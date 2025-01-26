using System;
using Lab3TestApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3TestApp.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Student>().HasData(
            GetStudents()
        );
    }

    public static List<Student> GetStudents() {
        return new List<Student> {
            new Student {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                EnrollmentDate = DateTime.Parse("2021-09-01")
            },
            new Student {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                EnrollmentDate = DateTime.Parse("2021-09-01")
            },
            new Student {
                Id = 3,
                FirstName = "Alice",
                LastName = "Smith",
                EnrollmentDate = DateTime.Parse("2021-09-01")
            },
            new Student {
                Id = 4,
                FirstName = "Bob",
                LastName = "Smith",
                EnrollmentDate = DateTime.Parse("2021-09-01")
            },
            new Student {
                Id = 5,
                FirstName = "Charlie",
                LastName = "Brown",
                EnrollmentDate = DateTime.Parse("2021-09-01")
            }
        };
    }
}
