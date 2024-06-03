using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatformService.Models
{
    [Table("platforms")]
    public class Platform
    {
        [Key]
        [Required]
        [Column("id")] 
        public int Id { get; set; }

        [Required]
        [Column("name")] 
        public string Name { get; set; }

        [Required]
        [Column("publisher")] 
        public string Publisher { get; set; }
        
        [Required]
        [Column("cost")] 
        public string Cost { get; set; }

    }
}
