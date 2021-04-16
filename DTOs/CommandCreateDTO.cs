using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandCreateDTO
    {
        [Required] [MaxLength(239)]
        public int Id { get; set; }
        
        [Required]
        public string HowTo { get; set; }
        
        public string Line { get; set; }
        
        public string Platform { get; set; }
    }
}