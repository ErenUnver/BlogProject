using System.ComponentModel.DataAnnotations;

namespace BlogProjectUI.Models
{
    public class UserSignalUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage ="Lütfen Adınızı ve Soyadınızı girin.")]
        public string NameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "Şifreleriniz uyuşmuyor tekrar giriniz.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Address")]
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
        public string Mail { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızo giriniz.")]
        public string UserName { get; set; }

    }
}
