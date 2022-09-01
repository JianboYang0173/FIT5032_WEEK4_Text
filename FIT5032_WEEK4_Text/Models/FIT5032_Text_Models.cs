using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_WEEK4_Text.Models
{
    public partial class FIT5032_Text_Models : DbContext
    {
        public FIT5032_Text_Models()
            : base("name=FIT5032_Text_Models")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
}
