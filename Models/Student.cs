using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string  StudentID { get; set; }
        public string FullName { get; set; }
        public string MaLOP { get; set; }
    }
}