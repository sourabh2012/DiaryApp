using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title should be between 3 to 60 Characters!")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required] 
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
