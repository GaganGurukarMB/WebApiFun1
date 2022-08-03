using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFun1.Models;

namespace WebApiFun1.Services
{
    public class StudentServices : IStudentServices
    {
        public string AddStudent(List<Students> lst, Students student)
        {
            lst.Add(student);
            return $"Added {student.Name}";
        }
        public string RemoveStudent(List<Students> lst, Students student)
        {
            int index = lst.FindIndex(stu => stu.RollNo == student.RollNo);
            lst.RemoveAt(index);
            return $"Removed {student.Name}";
        }
        public string UpdateStudent(List<Students> lst, Students student)
        {
            int index = lst.FindIndex(stu => stu.RollNo == student.RollNo);
            lst[index].Name = student.Name;
            lst[index].Marks = student.Marks;
            return $"Updated {student.Name}";
        }
    }
}
