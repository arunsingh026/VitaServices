using System.Data.Entity;
using LEGO.ENTITY;

namespace LEGO.FDAL.DBContext
{
    public partial class DBContxt : DbContext
    {
        public DBContxt()
            : base("name=SEEntities")
        {
        }
        public virtual DbSet<CoreMember> CoreMembers { get; set; }
        public virtual DbSet<CoreUser> CoreUsers { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
    }
}
