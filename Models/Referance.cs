using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class Referance
	{
		[Key]
		public int ReferansID { get; set; }

		public string ReferansAd { get; set; }

		public string ReferansResimUrl { get; set; }


		public string ReferansMeslek { get; set; }

		public string ReferansYazisi { get; set; }

	}
}

