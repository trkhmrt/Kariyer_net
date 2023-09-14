using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class Firma
	{
		[Key]
		public int FirmaID { get; set; }
		public string FirmaAdi { get; set; }
		public string FirmaAciklama { get; set; }
	}

}

