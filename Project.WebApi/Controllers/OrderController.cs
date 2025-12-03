using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Validation.RequestModels.OrderRequestModels;
using Project.Validation.ResponseModels.OrderResponseModels;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;
        private readonly IMapper _mapper;

        public OrderController(IOrderManager orderManager, IMapper mapper)
        {
            _orderManager = orderManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orderDtos = await _orderManager.GetAllAsync();
            var responseModels = _mapper.Map<List<OrderResponseModel>>(orderDtos);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var orderDto = await _orderManager.GetByIdAsync(id);
            if (orderDto == null)
            {
                return NotFound($"ID'si {id} olan sipariş bulunamadı.");
            }
            var responseModel = _mapper.Map<OrderResponseModel>(orderDto);
            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderRequestModel request)
        {
            var orderDto = _mapper.Map<OrderDto>(request);
            var createdOrderDto = await _orderManager.AddAsync(orderDto);
            var responseModel = _mapper.Map<OrderResponseModel>(createdOrderDto);
            return CreatedAtAction(nameof(GetById), new { id = responseModel.ID }, responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateOrderRequestModel request)
        {
            var orderDto = _mapper.Map<OrderDto>(request);
            var updatedOrderDto = await _orderManager.UpdateAsync(orderDto);
            if (updatedOrderDto == null)
            {
                return NotFound($"ID'si {request.ID} olan sipariş bulunamadı veya güncellenemedi.");
            }
            var responseModel = _mapper.Map<OrderResponseModel>(updatedOrderDto);
            return Ok(responseModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _orderManager.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound($"ID'si {id} olan sipariş bulunamadı veya silinemedi.");
            }
            return NoContent();
        }
    }
}