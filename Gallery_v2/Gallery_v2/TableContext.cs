using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Gallery_v2
{
    class TableContext : DbContext
    {
        public TableContext()
           //: base("gallery.Properties.Settings.gallery_dbConnectionString")
           : base("Gallery_v2.Properties.Settings.GallV2ConnectionString")
        // : base("gallery.Properties.Settings.dbConnectionString")
        { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Expositions> Expositions { get; set; }
        public DbSet<Statuses> Statuses { get; set; }
        public DbSet<ExpToPic> ExpToPics { get; set; }
        
    }
}
