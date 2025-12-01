using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Conf.Options
{
    public abstract class BaseConfigration<T> : IEntityTypeConfiguration<T> where T:BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            /*
            builder.Property(x => x.CreatedDate).HasColumnName("Veri yaratilma tarihi");
            builder.Property(x => x.UpdatedDate).HasColumnName("Veri guncellenme tarihi");
            builder.Property(x => x.DeletedDate).HasColumnName("Veri silinme tarihi");
            builder.Property(x => x.Status).HasColumnName("Veri durumu");
            */

        }
    }
}
