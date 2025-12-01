using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;

namespace Project.Conf.Options
{
    public class OrderDetailConfigration : BaseConfigration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });
        }
    }
}
