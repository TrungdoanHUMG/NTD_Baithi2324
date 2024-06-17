using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTD_Baithi2324.Models
{
    [Table("Person")]
    public class NTD195Person
    {
        [Key]
        public string NTD195PersonID { get; set; }
        public string NTD195FullName { get; set; }
        public string NTD195Diachi { get; set; }
    }
}
