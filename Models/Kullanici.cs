using System;
using Microsoft.AspNetCore.Identity;

namespace Kariyer_net.Models
{
	public class Kullanici:IdentityUser
	{
        public string NameSurname { get; set; }

        public string? ImageUrl { get; set; }

        public string Cv { get; set; }
    }
}

