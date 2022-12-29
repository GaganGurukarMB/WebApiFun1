using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFun1.Models;
using WebApiFun1.Services;

namespace WebApiFun1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> lst = new List<Students>();

        private readonly IStudentServices _StudentServices;
        public StudentsController(IStudentServices studentServices)
        {
            _StudentServices = studentServices;
        }
        
        [HttpGet]
        public List<Students> Get()
        {
            return lst;
        }

        [HttpPost]
        public List<string> Insert([FromBody] List<Students> students)
        {
            List<string> result = new List<string>();
            foreach (var student in students)
            {
                lst.Add(new Students { Name = student.Name, RollNo = student.RollNo, Marks = student.Marks });
                names.Add(student.Name+" Added");
            }
            return names;
            //changes
            //foreach (var student in students)
            //{
            //    result.Add(_StudentServices.AddStudent(lst, student));
            //}
            //return result;
        }

        [HttpDelete]
        public List<string> Delete([FromBody] List<Students> students)
        {
            List<string> result = new List<string>();
            foreach (var student in students)
            {
                int index = lst.FindIndex(stu => stu.RollNo == student.RollNo);
                lst.RemoveAt(index);
                result.Add(student.Name+" Removed");
            }
            return result;

            //foreach (var student in students)
            //{
            //    result.Add(_StudentServices.RemoveStudent(lst, student));
            //}
            //return result;
        }

        [HttpPut]
        public List<string> Update([FromBody] List<Students> students)
        {
            List<string> result = new List<string>();
            foreach (var student in students)
            {
                int index = lst.FindIndex(stu => stu.RollNo == student.RollNo);
                lst[index].Name = student.Name;
                lst[index].Marks = student.Marks;
                result.Add(student.Name+" Updated");
            }
            return result;
            
            //foreach (var student in students)
            //{
            //    result.Add(_StudentServices.UpdateStudent(lst, student));
            //}
            //return result;
        }
    }
}
