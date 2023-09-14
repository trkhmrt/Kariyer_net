using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class Contact
	{
		[Key]
		public int ContactID { get; set; }

		public string Lokasyon { get; set; }

		public string Telefon { get; set; }


		public string Mail { get; set; }

	}
}

