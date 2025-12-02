using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models.RequestModels.Categories
{
    public class UpdateCategoryRequestModel
    {
        public int Id { get; set; }

        //[Required (ErrorMessage="bu alan bo gecilemez")]

        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
