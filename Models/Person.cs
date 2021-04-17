using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Models
{
    public class Person
    {
        public int Id { get; set; }

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