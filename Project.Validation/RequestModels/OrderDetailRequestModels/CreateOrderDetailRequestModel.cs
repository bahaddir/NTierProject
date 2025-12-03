using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.RequestModels.AppUserProfileRequestModels
{
    public class CreateOrderDetailRequestModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
