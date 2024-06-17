using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models{
    [Table("Student")]
    public class NTD195Student
    {
        [Key]
        public string  NTD195StudentID { get; set; }
        public string NTD195FullName { get; set; }
        public string NTD195MaLOP { get; set; }
    }
}