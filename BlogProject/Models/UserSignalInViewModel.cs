using System.ComponentModel.DataAnnotations;

namespace BlogProjectUI.Models
{
    public class UserSignalInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
