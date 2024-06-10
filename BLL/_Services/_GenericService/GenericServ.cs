using _DAL._Repositories._GenericRepository;
using AutoMapper;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services._GenericService
{
    public class GenericServ<TypeOfDTO, Type> : IGenericServ<TypeOfDTO> where TypeOfDTO : class where Type : class
    {
        public readonly IGenericRepo<Type> _repo;
        public readonly IMapper _mapper;

        public GenericServ(IGenericRepo<Type> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        #region Get 
        public ApiResponse<IEnumerable<TypeOfDTO>> GetAll()
        {
            var Result = _repo.GetAll();
            if (null == Result)
            {
                throw new Exception();
            }
            var apiResponse = new ApiResponse<IEnumerable<TypeOfDTO>>();
            var finalResult = _mapper.Map<IEnumerable<TypeOfDTO>>(Result);
            apiResponse.Data = finalResult;
            return apiResponse;
        }

        public async Task<ApiResponse<IEnumerable<TypeOfDTO>>> GetAllAsync()
        {
            var apiResponse = new ApiResponse<IEnumerable<TypeOfDTO>>();
            var Result = await _repo.GetAllAsync();
            var finalResult = _mapper.Map<IEnumerable<TypeOfDTO>>(Result);
            apiResponse.Data = finalResult;
            return apiResponse;
        }

        public async Task<ApiResponse<TypeOfDTO>> GetByID(int id)
        {
            var apiResponse = new ApiResponse<TypeOfDTO>();

            if (0 == id)
            {
                throw new Exception();
            }

            var Result = await _repo.GetByID(id);

            if (Result == null)
            {
                throw new Exception();
            }

            var finalResult = _mapper.Map<TypeOfDTO>(Result);
            apiResponse.Data = finalResult;
            return apiResponse;
        }

        #endregion

        #region Add
        public async Task<ApiResponse<TypeOfDTO>> AddElement(TypeOfDTO itemDto)
        {
            if (itemDto == null)
            {
                throw new Exception();
            }
            var apiResponse = new ApiResponse<TypeOfDTO>();
            var request = _mapper.Map<Type>(itemDto);
            var response = await _repo.AddElement(request);
            apiResponse.Data = _mapper.Map<TypeOfDTO>(response);
            apiResponse.Meesage = "Added Successfully";
            return apiResponse;
        }

        #endregion

        #region Update
        public async Task<ApiResponse<TypeOfDTO>> UpdateElement(TypeOfDTO itemDto)
        {
            var apiResponse = new ApiResponse<TypeOfDTO>();
            var request = _mapper.Map<Type>(itemDto);
            var response = await _repo.UpdateElement(request);
            apiResponse.Data = _mapper.Map<TypeOfDTO>(response);
            return apiResponse;
        }
        #endregion

        #region Delete
        public async Task<ApiResponse<TypeOfDTO>> Delete(TypeOfDTO itemDto)
        {
            var apiResponse = new ApiResponse<TypeOfDTO>();
            var request = _mapper.Map<Type>(itemDto);
            var response = await _repo.Delete(request);
            apiResponse.Data = _mapper.Map<TypeOfDTO>(response);
            return apiResponse;
        }

        public async Task<ApiResponse<TypeOfDTO>> DeleteById(int id)
        {
            var apiResponse = new ApiResponse<TypeOfDTO>();
            var request = await _repo.DeleteById(id);
            apiResponse.Data = _mapper.Map<TypeOfDTO>(request);
            return apiResponse;

        }

        #endregion 

    }
}
