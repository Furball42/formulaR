using System.ComponentModel.DataAnnotations;

namespace FormulaR.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}