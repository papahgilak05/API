using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("AccountRole")]
    public class AccountRole
    {
        public string NIK { get; set; }
        public int RoleId { get; set; }

        [JsonIgnore]
        public virtual Role Role { get; set; }
        [JsonIgnore]
        public virtual Account Account { get; set; }
    }
}
