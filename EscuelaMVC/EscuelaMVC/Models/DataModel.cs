using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace EscuelaMVC.Models
{
    public class DataModel : DbContext
    {
        public DataModel() : base("DataModel") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
    }
}
