using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models
{
    [Table("Employee")]
    public class Empoyee
    {
        [Key]
        public string EmpoyeeID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}