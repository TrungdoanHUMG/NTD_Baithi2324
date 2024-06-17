using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models
{
    [Table("Employee")]
    public class NTD195Employee   {
        [Key]
        public string NTD195EmployeeID { get; set; }
        public string NTD195FullName { get; set; }
        public string NTD195Address { get; set; }
    }
}
