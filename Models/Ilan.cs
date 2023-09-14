using System;
using System.ComponentModel.DataAnnotations;

namespace Kariyer_net.Models
{
	public class Ilan
	{

        [Key]
		public int IlanID { get; set; }
        public string IlanBaslik { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string CalismaTuru { get; set; }
        public string IlanAciklama { get; set; }
        public string IlanSorumluluklar { get; set; }
        public string IlanYetenekler { get; set; }
        public DateTime YayimlanmaTarihi { get; set; }
        public int BasvuruSayisi { get; set; }
        public string Firma { get; set; }
        public int Maas { get; set; }
        public int KategoriID { get; set; }
        public string IlanFotoUrl { get; set; }

        public Kategori Kategori { get; set; }





        //KATEGORİ İLİŞKİLENDİRECEK

    }
}

