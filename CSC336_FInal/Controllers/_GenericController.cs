using BLL._Services._GenericService;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_FInal.Controllers
{
    [Route("API/[Controller]")]
    [ApiController]
    public class _GenericController<DTO> : Controller where DTO : class
    {
        public readonly IGenericServ<DTO> _Service;
        public _GenericController(IGenericServ<DTO> service)
        {
            _Service = service;
        }

        #region Get
        [HttpGet("GETAll")]
        public ApiResponse<IEnumerable<DTO>> GetAll()
        {
            return _Service.GetAll();
        }
        [HttpGet("GetAllAsync")]
        public async Task<ApiResponse<IEnumerable<DTO>>> GetallAsync()
        {
            return await _Service.GetAllAsync();
        }
        [HttpGet("GetByID")]
        public async Task<ApiResponse<DTO>> GetByID(int id)
        {
            return await _Service.GetByID(id);
        }
        #endregion

        #region ADD 
        [HttpPost("AddElement")]
        public async Task<ApiResponse<DTO>> AddElement(DTO dto)
        {
            return await _Service.AddElement(dto);
        }
        #endregion
        [HttpPut("UpdateElement")]

        #region Update 
        public async Task<ApiResponse<DTO>> UpdateElement(DTO dto)
        {
            return await _Service.UpdateElement(dto);
        }
        #endregion
        [HttpDelete("DeleteElement")]

        #region Delete

        public async Task<ApiResponse<DTO>> Delete(DTO dto)
        {
            return await _Service.Delete(dto);
        }
        [HttpDelete("DeleteByID")]

        public async Task<ApiResponse<DTO>> DeleteByID(int id)
        {
            return await _Service.DeleteById(id);
        }
        #endregion
    }
}
