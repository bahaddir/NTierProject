using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.ResponseModels.OrderResponseModels
{
    public class OrderResponseModel
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }

}
