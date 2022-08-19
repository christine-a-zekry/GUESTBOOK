using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Guest_book.Models
{
    [Table("Guest",Schema ="GuestBook")]
    public class Guest
    {
        [Key]
        [Display(Name ="ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Guest Name")]
      [Column(TypeName ="varchar(200)")]
        public string? Guest_Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        [Display(Name = "Guest Address")]
        public string? Guest_Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Guest Email")]
        public string? Guest_Email { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Send a message here!!")]
        public string? Messages { get; set; }

     

    }
}
