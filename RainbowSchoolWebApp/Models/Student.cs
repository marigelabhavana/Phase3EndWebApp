using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolWebApp.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?Course { get; set; }
        public string ?Class {  get; set; }
        public string ?Gender { get; set; }

    }
}
