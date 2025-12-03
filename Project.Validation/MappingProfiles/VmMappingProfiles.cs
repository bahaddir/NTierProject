using AutoMapper;
using Project.Bll.Dtos;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using Project.Validation.RequestModels.AppUserRequestModels;
using Project.Validation.ResponseModels.AppUserProfileResponseModels;
using Project.Validation.ResponseModels.CategoryResponseModels;
using Project.Validation.ResponseModels.OrderDetailResponseModels;
using Project.Validation.ResponseModels.OrderResponseModels;
using Project.Validation.ResponseModels.ProductResponseModels;
using Project.Validation.Validators.AppUserProfileValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateAppUserRequestModel, AppUserDto>();
            CreateMap<UpdateAppUserRequestModel, AppUserDto>();
            CreateMap<AppUserDto, AppUserResponseModel>();

            CreateMap<CreateAppUserProfileRequestModel, AppUserProfileDto>();
            CreateMap<UpdateAppUserProfileRequestModel, AppUserProfileDto>();
            CreateMap<AppUserProfileDto, AppUserProfileResponseModel>();

            CreateMap<CreateCategoryRequestModel, CategoryDto>();
            CreateMap<UpdateCategoryRequestModel, CategoryDto>();
            CreateMap<CategoryDto, CategoryResponseModel>();

            CreateMap<CreateProductRequestModel, ProductDto>();
            CreateMap<UpdateProductRequestModel, ProductDto>();
            CreateMap<ProductDto, ProductResponseModel>();
            
            CreateMap<CreateOrderRequestModel, OrderDto>();
            CreateMap<UpdateOrderRequestModel, OrderDto>();
            CreateMap<OrderDto, OrderResponseModel>();

            CreateMap<CreateOrderDetailRequestModel, OrderDetailDto>();
            CreateMap<UpdateOrderDetailRequestModel, OrderDetailDto>();
            CreateMap<OrderDetailDto, OrderDetailResponseModel>();
        }
    }

}
