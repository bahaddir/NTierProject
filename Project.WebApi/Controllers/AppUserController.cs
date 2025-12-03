using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Validation.RequestModels.AppUserRequestModels;
using Project.Validation.ResponseModels.AppUserResponseModels;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserManager _appUserManager;
        private readonly IMapper _mapper;

        public AppUserController(IAppUserManager appUserManager, IMapper mapper)
        {
            _appUserManager = appUserManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var appUserDtos = await _appUserManager.GetAllAsync();
            var responseModels = _mapper.Map<List<AppUserResponseModel>>(appUserDtos);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var appUserDto = await _appUserManager.GetByIdAsync(id);
            if (appUserDto == null)
            {
                return NotFound($"ID'si {id} olan kullanıcı bulunamadı.");
            }
            var responseModel = _mapper.Map<AppUserResponseModel>(appUserDto);
            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAppUserRequestModel request)
        {
            var appUserDto = _mapper.Map<AppUserDto>(request);
            var createdAppUserDto = await _appUserManager.AddAsync(appUserDto);
            var responseModel = _mapper.Map<AppUserResponseModel>(createdAppUserDto);
            return CreatedAtAction(nameof(GetById), new { id = responseModel.ID }, responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAppUserRequestModel request)
        {
            var appUserDto = _mapper.Map<AppUserDto>(request);
            var updatedAppUserDto = await _appUserManager.UpdateAsync(appUserDto);
            if (updatedAppUserDto == null)
            {
                return NotFound($"ID'si {request.ID} olan kullanıcı bulunamadı veya güncellenemedi.");
            }
            var responseModel = _mapper.Map<AppUserResponseModel>(updatedAppUserDto);
            return Ok(responseModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _appUserManager.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound($"ID'si {id} olan kullanıcı bulunamadı veya silinemedi.");
            }
            return NoContent();
        }
    }
}