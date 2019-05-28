using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class DataContext: DbContext
    {
        public DataContext()
            : base("Name=IndimaretConn")
        {
            //Database.SetInitializer<DataContext>(null);
            Database.SetInitializer(new Initializer());
        }

        public virtual DbSet<BarangModel> BarangModel { get; set; }
    }
}
