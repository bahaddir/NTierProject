namespace Project.Entities.Models
{
    public class Order:BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }

        //rel. prop.
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    } 
}
