using System.Collections.Generic;
using System.Linq;
using FirstWebApp.Model;
using Microsoft.AspNetCore.Mvc;


namespace FirstWebApp{
    [Route("api/students")]
    public class StudentsRestService:Controller{
        private MyDbContext dbService;
        public StudentsRestService(MyDbContext dbContext){
            dbService = dbContext;
        }
        [HttpGet]
        public IEnumerable<Student> list(){
            return dbService.students;
        }
        [HttpPost]
        public Student Save([FromBody]Student student){
            dbService.students.Add(student);
            dbService.SaveChanges();
            return student;
        }
        [HttpGet("{Id}")]
        public Student GetOne(long Id){
            return dbService.students.FirstOrDefault(st=>st.Id == Id);
        }
        [HttpDelete("{Id}")]
        public void Remove(long Id){
            Student student = dbService.students.FirstOrDefault(st=>st.Id == Id);
            dbService.students.Remove(student);
            dbService.SaveChanges();
        }
        [HttpPut("{Id}")]
        public Student Update(long Id, [FromBody] Student student){
            student.Id = (int)Id;
            dbService.students.Update(student);
            dbService.SaveChanges();
            return student;
        }
    
    }
}