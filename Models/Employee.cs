using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models
{
    [Table("Employee")]
    public class Empoyee
    {
        [Key]
        public string NTD195EmpoyeeID { get; set; }
        public string NTD195FullName { get; set; }
        public string NTD195Address { get; set; }
    }
}