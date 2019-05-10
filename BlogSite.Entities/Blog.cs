using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
