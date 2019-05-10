using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Entities
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAciklama { get; set; }

        public virtual List<Blog> Blog { get; set; }
    }
}
