using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkınTurizmProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
		public string ConfirmPassword { get; set; }
	};
}
