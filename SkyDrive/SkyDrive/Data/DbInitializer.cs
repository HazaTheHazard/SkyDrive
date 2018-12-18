using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkyDrive.Models;

namespace SkyDrive.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SkyDriveContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            //if (context.Student.Any())
           // {
           //   return;   // DB has been seeded
           // }

            var students = new Student[]
            {
                new Student {
                    FirstMidName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01")
                },
                new Student { FirstMidName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstMidName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Nino",     LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") }
            };

            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var instructors = new Instructor[]
            {
                new Instructor { FirstMidName = "Kim",     LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11") },
                new Instructor { FirstMidName = "Fadi",    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06") },
                new Instructor { FirstMidName = "Roger",   LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01") },
                new Instructor { FirstMidName = "Candace", LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15") },
                new Instructor { FirstMidName = "Roger",   LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12") }
            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department { Name = "English",     Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = instructors.Single( i => i.LastName == "Abercrombie").ID },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = instructors.Single( i => i.LastName == "Fakhouri").ID },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = instructors.Single( i => i.LastName == "Harui").ID },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = instructors.Single( i => i.LastName == "Kapoor").ID }
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3,
                    DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID
                },
                new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3,
                    DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID
                },
                new Course {CourseID = 4041, Title = "Macroeconomics", Credits = 3,
                    DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID
                },
                new Course {CourseID = 1045, Title = "Calculus",       Credits = 4,
                    DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID
                },
                new Course {CourseID = 3141, Title = "Trigonometry",   Credits = 4,
                    DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID
                },
                new Course {CourseID = 2021, Title = "Composition",    Credits = 3,
                    DepartmentID = departments.Single( s => s.Name == "English").DepartmentID
                },
                new Course {CourseID = 2042, Title = "Literature",     Credits = 4,
                    DepartmentID = departments.Single( s => s.Name == "English").DepartmentID
                },
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Fakhouri").ID,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Harui").ID,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Kapoor").ID,
                    Location = "Thompson 304" },
            };

            var note = new Note[]
            {
                new Note
                {
                    UserID = "2",
                    Title = "NewTitle",
                    Body = "Vivamus maximus luctus hendrerit. Sed id erat consectetur, laoreet ex nec, pretium augue. Quisque congue iaculis nisl et imperdiet. Nunc dictum id orci ut malesuada. Proin mollis magna eget euismod aliquam. Vestibulum ac faucibus libero. Aenean scelerisque erat eu feugiat feugiat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Integer in urna libero. Curabitur nisl dui, pharetra et elementum rhoncus, congue non leo. Morbi vel leo at tellus dignissim venenatis et vel ipsum. Curabitur suscipit laoreet ex. Curabitur accumsan, nisi at sagittis ultricies, tellus enim sollicitudin massa, eu lobortis nisi mi condimentum quam. Vestibulum ornare neque a diam fringilla rhoncus. Quisque mollis sed ligula ut ullamcorper. Morbi pretium, nisl id placerat ullamcorper, arcu ligula dapibus augue, at laoreet ligula sapien eget sem. Nam interdum nulla facilisis, condimentum lacus non, rutrum nunc. Nunc dictum molestie dui nec dignissim. Phasellus in hendrerit massa. Morbi varius felis nisi, a commodo est euismod sed. Donec augue magna, finibus sit amet felis vel, varius cursus odio. Cras imperdiet sodales lectus, sed ornare ipsum egestas at. Proin tristique, arcu at ultricies rutrum, lectus dolor malesuada nisl, ut pretium arcu mauris a tellus. Curabitur egestas rutrum libero, ut tempor diam euismod quis. Nunc sit amet ipsum diam. Sed volutpat fermentum nisi quis semper. Suspendisse id felis vel erat egestas luctus. Morbi eu neque libero. Nullam eu tellus vitae velit ornare porta. Mauris rutrum ultricies aliquam. Donec consectetur tortor id euismod vulputate. Cras tortor tellus, feugiat quis egestas vel, scelerisque id ex. Donec ac pretium neque. Nullam iaculis nunc lacinia, ornare neque sed, dictum justo. Aenean sit amet est sit amet ex maximus finibus et at elit. Proin magna felis, facilisis sed vehicula vel, tristique ac ipsum. Nulla facilisi. Duis nec ultrices augue. Etiam dignissim quis erat vel tincidunt. Sed ut gravida nibh, eu eleifend neque.",
                },
                new Note
                {
                    UserID = "2",
                    Title = "NewTitle1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ac ante massa. Integer eu turpis suscipit, lobortis massa gravida, hendrerit justo. Nullam tempus congue sagittis. Integer tempus, ante et placerat ultrices, dui nisi aliquet eros, ut mattis lacus elit id nisl. Sed vitae lectus eget tellus laoreet placerat ut vel turpis. In hac habitasse platea dictumst. In laoreet felis sed ante sollicitudin feugiat. Maecenas lobortis augue a commodo porta. Maecenas varius, eros efficitur volutpat luctus, dolor dui dignissim purus, pulvinar dapibus nunc odio non lectus. Donec maximus dapibus nisl sed efficitur. Nullam ornare ac urna eget suscipit. Integer condimentum interdum elit, non maximus felis sollicitudin sed.Maecenas augue metus, sodales eget dictum eu, efficitur at ante. Nullam gravida massa efficitur nulla congue, et maximus nisl dapibus. Donec et nibh nibh. Ut vehicula, metus ut ullamcorper facilisis, ligula risus fermentum nisl, a congue metus risus ut urna. Nunc vestibulum finibus bibendum. Aenean consectetur, felis nec tincidunt dignissim, erat metus suscipit purus, dignissim iaculis erat dui vitae nunc. Sed malesuada ullamcorper metus, id feugiat nunc euismod vestibulum. Suspendisse tincidunt dolor quis varius aliquet. Morbi mollis augue ac augue condimentum mattis. Suspendisse suscipit malesuada tortor at iaculis. Morbi tincidunt, turpis et pharetra aliquam, eros neque porta est, vel iaculis magna nibh in nunc. Suspendisse nec porttitor neque. Morbi bibendum consectetur laoreet.Vivamus maximus luctus hendrerit. Sed id erat consectetur, laoreet ex nec, pretium augue. Quisque congue iaculis nisl et imperdiet. Nunc dictum id orci ut malesuada. Proin mollis magna eget euismod aliquam. Vestibulum ac faucibus libero. Aenean scelerisque erat eu feugiat feugiat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Integer in urna libero. Curabitur nisl dui, pharetra et elementum rhoncus, congue non leo. Morbi vel leo at tellus dignissim venenatis et vel ipsum. Curabitur suscipit laoreet ex.",
                }
            };
            foreach (Note n in note)
            {
                context.Note.Add(n);
            }
            context.SaveChanges();

            var auth = new Auth[]
            {
                new Auth
                {
                    Email = "matthew.king4@sky.uk",
                    Password = "abcd1234",
                    FullName = "Matt King"
                },
                new Auth
                {
                    Email = "test@sky.uk",
                    Password = "abcd1234",
                    FullName = "test"
                }
            };

            foreach (Auth a in auth)
            {
                context.Auth.Add(a);
            }
            context.SaveChanges();

            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();

            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Literature" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
            };

            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    Grade = Grade.A
                },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Anand").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Anand").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
                    Grade = Grade.B
                    },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry").CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Li").ID,
                    CourseID = courses.Single(c => c.Title == "Composition").CourseID,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Justice").ID,
                    CourseID = courses.Single(c => c.Title == "Literature").CourseID,
                    Grade = Grade.B
                    }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollment.Where(
                    s =>
                            s.Student.ID == e.StudentID &&
                            s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollment.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}