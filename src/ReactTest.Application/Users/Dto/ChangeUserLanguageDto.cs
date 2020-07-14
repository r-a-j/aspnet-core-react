using System.ComponentModel.DataAnnotations;

namespace ReactTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}