using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Education")]
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Degree { get; set; }
        public string GPA { get; set; }
        public int UniversitiesId { get; set; }
        [JsonIgnore]
        public virtual ICollection<Profiling> Profilings { get; set; }
        [JsonIgnore]
        public virtual University Universities { get; set; }
    }
}
