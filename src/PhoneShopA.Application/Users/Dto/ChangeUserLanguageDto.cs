using System.ComponentModel.DataAnnotations;

namespace PhoneShopA.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}