using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FirstWebApp.Model{
    public class Student{
        [Key]
        public int Id { get; set; }
        [Required, StringLength(25)]
        public string Name { get; set; }
        public int Score { get; set; }
    }
}