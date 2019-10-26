using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>(); //Inicializa Lista
        public StudentStore()
        {
            Students.Add(new Student
            {
                Age=26,
                Name="Daniel",
                LastName="Londoño",
                Nit="1037629046"
            });
            Students.Add(new Student
            {
                Age = 15,
                Name = "El",
                LastName = "Bromas",
                Nit = "100"
            });
            Students.Add(new Student
            {
                Age = 30,
                Name = "Tribi",
                LastName = "Lin",
                Nit = "654"
            });
            Students.Add(new Student
            {
                Age = 17,
                Name = "Bad",
                LastName = "Bunny",
                Nit = "15234"
            });
            Students.Add(new Student
            {
                Age = 31,
                Name = "Esteban",
                LastName = "Quito",
                Nit = "1557864"
            });
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Age = student.Age;
            currentStudent.Nit = student.Nit;
        }

        internal Student GetStudentById(Guid id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);

        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents() {
            return this.Students;
        }



    }
}
