using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Validation.RequestModels.OrderDetailRequestModels;
using Project.Validation.ResponseModels.OrderDetailResponseModels;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailManager _orderDetailManager;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailManager orderDetailManager, IMapper mapper)
        {
            _orderDetailManager = orderDetailManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orderDetailDtos = await _orderDetailManager.GetAllAsync();
            var responseModels = _mapper.Map<List<OrderDetailResponseModel>>(orderDetailDtos);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var orderDetailDto = await _orderDetailManager.GetByIdAsync(id);
            if (orderDetailDto == null)
            {
                return NotFound($"ID'si {id} olan sipariş detayı bulunamadı.");
            }
            var responseModel = _mapper.Map<OrderDetailResponseModel>(orderDetailDto);
            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderDetailRequestModel request)
        {
            var orderDetailDto = _mapper.Map<OrderDetailDto>(request);
            var createdOrderDetailDto = await _orderDetailManager.AddAsync(orderDetailDto);
            var responseModel = _mapper.Map<OrderDetailResponseModel>(createdOrderDetailDto);
            return CreatedAtAction(nameof(GetById), new { id = responseModel.ID }, responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateOrderDetailRequestModel request)
        {
            var orderDetailDto = _mapper.Map<OrderDetailDto>(request);
            var updatedOrderDetailDto = await _orderDetailManager.UpdateAsync(orderDetailDto);
            if (updatedOrderDetailDto == null)
            {
                return NotFound($"ID'si {request.ID} olan sipariş detayı bulunamadı veya güncellenemedi.");
            }
            var responseModel = _mapper.Map<OrderDetailResponseModel>(updatedOrderDetailDto);
            return Ok(responseModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _orderDetailManager.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound($"ID'si {id} olan sipariş detayı bulunamadı veya silinemedi.");
            }
            return NoContent();
        }
    }
}