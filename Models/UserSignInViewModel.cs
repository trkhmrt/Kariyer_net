using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class UserSignInViewModel
	{
		[Required(ErrorMessage="Lütfen kullanıcı adını girin")]
		public string? username { get; set; }

        [Required(ErrorMessage = "Lütfen şifre adını girin")]
        public string? password { get; set; }

    }
}

