using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class UserSignUpViewModel
	{
		[Display(Name ="Ad soyad")]
		[Required(ErrorMessage ="Lütfen ad soyad giriniz")]

		public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]

        public string Password { get; set; }

        [Display(Name = "Ad soyad")]
        [Compare("Password",ErrorMessage = "Şifreler uyuşmuyor")]

        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen mail giriniz")]

        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı adınızı giriniz")]

        public string UserName { get; set; }

        [Display(Name = "CV")]
        

        public IFormFile? Cv { get; set; }

    }
}

