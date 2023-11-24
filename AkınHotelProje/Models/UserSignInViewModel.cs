using System.ComponentModel.DataAnnotations;

namespace AkınTurizmProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını giriniz")]
        public string? username { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını giriniz")]
        public string? password { get; set; }
    }
}
