using System.ComponentModel.DataAnnotations;

namespace blogger.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}