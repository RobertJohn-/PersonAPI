using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Dtos
{
    public class PersonCreateDto
    {
        [Required]
        [MaxLength(20)]
        public string FName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LName { get; set; }

        
        [Required]
        public bool CheckFlag { get; set; }
    }
}