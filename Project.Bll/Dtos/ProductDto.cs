namespace Project.Bll.Dtos
{
    public class ProductDto : BaseDto
    {
        public decimal UnitPrice { get; set; }
                public string ProductName { get; set; }
        public int? CategoryId { get; set; }

    }



}
