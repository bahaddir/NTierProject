using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Validation.RequestModels.ProductRequestModels;
using Project.Validation.ResponseModels.ProductResponseModels;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        private readonly IMapper _mapper;

        public ProductController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productDtos = await _productManager.GetAllAsync();
            var responseModels = _mapper.Map<List<ProductResponseModel>>(productDtos);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var productDto = await _productManager.GetByIdAsync(id);
            if (productDto == null)
            {
                return NotFound($"ID'si {id} olan ürün bulunamadı.");
            }
            var responseModel = _mapper.Map<ProductResponseModel>(productDto);
            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductRequestModel request)
        {
            var productDto = _mapper.Map<ProductDto>(request);
            var createdProductDto = await _productManager.AddAsync(productDto);
            var responseModel = _mapper.Map<ProductResponseModel>(createdProductDto);
            return CreatedAtAction(nameof(GetById), new { id = responseModel.ID }, responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductRequestModel request)
        {
            var productDto = _mapper.Map<ProductDto>(request);
            var updatedProductDto = await _productManager.UpdateAsync(productDto);
            if (updatedProductDto == null)
            {
                return NotFound($"ID'si {request.ID} olan ürün bulunamadı veya güncellenemedi.");
            }
            var responseModel = _mapper.Map<ProductResponseModel>(updatedProductDto);
            return Ok(responseModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _productManager.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound($"ID'si {id} olan ürün bulunamadı veya silinemedi.");
            }
            return NoContent();
        }
    }
}