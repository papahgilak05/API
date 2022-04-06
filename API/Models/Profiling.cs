using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Profiling")]
    public class Profiling
    {
        [Key]
        public string NIK { get; set; }

        public int EducationsId { get; set; }
        [JsonIgnore]
        public virtual Account Accounts { get; set; }
        [JsonIgnore]

        public virtual Education Educations { get; set; }
    }
}
