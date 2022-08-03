using System.Collections.Generic;
using WebApiFun1.Models;

namespace WebApiFun1.Services
{
    public interface IStudentServices
    {
        string AddStudent(List<Students> lst, Students student);
        string RemoveStudent(List<Students> lst, Students student);
        string UpdateStudent(List<Students> lst, Students student);
    }
}