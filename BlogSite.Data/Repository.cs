using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlogSite.Data
{
    public class Repository<T> where T:class
    {
        BlogContext db;

        private DbSet<T> _objectset;

        public Repository()
        {
            var _options = new DbContextOptionsBuilder<BlogContext>();

            var context = new BlogContext(_options.Options);

            db = context;

            _objectset = db.Set<T>();
        }
        public List<T> List()
        {
            return _objectset.ToList();
        }
    }
}
