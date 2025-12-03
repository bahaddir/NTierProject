using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using Project.Validation.ResponseModels.AppUserProfileResponseModels;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserProfileController : ControllerBase
    {
        private readonly IAppUserProfileManager _appUserProfileManager;
        private readonly IMapper _mapper;

        public AppUserProfileController(IAppUserProfileManager appUserProfileManager, IMapper mapper)
        {
            _appUserProfileManager = appUserProfileManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var appUserProfileDtos = await _appUserProfileManager.GetAllAsync();
            var responseModels = _mapper.Map<List<AppUserProfileResponseModel>>(appUserProfileDtos);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var appUserProfileDto = await _appUserProfileManager.GetByIdAsync(id);
            if (appUserProfileDto == null)
            {
                return NotFound($"ID'si {id} olan kullanıcı profili bulunamadı.");
            }
            var responseModel = _mapper.Map<AppUserProfileResponseModel>(appUserProfileDto);
            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAppUserProfileRequestModel request)
        {
            var appUserProfileDto = _mapper.Map<AppUserProfileDto>(request);
            var createdAppUserProfileDto = await _appUserProfileManager.AddAsync(appUserProfileDto);
            var responseModel = _mapper.Map<AppUserProfileResponseModel>(createdAppUserProfileDto);
            return CreatedAtAction(nameof(GetById), new { id = responseModel.ID }, responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAppUserProfileRequestModel request)
        {
            var appUserProfileDto = _mapper.Map<AppUserProfileDto>(request);
            var updatedAppUserProfileDto = await _appUserProfileManager.UpdateAsync(appUserProfileDto);
            if (updatedAppUserProfileDto == null)
            {
                return NotFound($"ID'si {request.ID} olan kullanıcı profili bulunamadı veya güncellenemedi.");
            }
            var responseModel = _mapper.Map<AppUserProfileResponseModel>(updatedAppUserProfileDto);
            return Ok(responseModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _appUserProfileManager.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound($"ID'si {id} olan kullanıcı profili bulunamadı veya silinemedi.");
            }
            return NoContent();
        }
    }
}