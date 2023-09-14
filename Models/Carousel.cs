using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class Carousel
	{
		[Key]
		public int CaroueselID { get; set; }

		public string CarouselBaslik { get; set; }

		public string CarouselAciklama { get; set; }

		public string CarouselFotoUrl { get; set; }


	}
}

