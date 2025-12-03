using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.ResponseModels.CategoryResponseModels
{
    public class CategoryResponseModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DataStatus Status { get; set; }
    }


}
