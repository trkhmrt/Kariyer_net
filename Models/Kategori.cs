using System;
namespace Kariyer_net.Models
{
	public class Kategori
	{
		public int KategoriID { get; set; }

		public string KategoriIsmi { get; set; }

		public string KategoriFoto { get; set; }

		public int KategoriBasvuranSayisi { get; set; }

		public  ICollection<Ilan> Ilans { get; set; }

	}
}

