using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services._GenericService
{
    public interface IGenericServ<TypeOfDTO> where TypeOfDTO : class
    {
        ApiResponse<IEnumerable<TypeOfDTO>> GetAll();

        Task<ApiResponse<IEnumerable<TypeOfDTO>>> GetAllAsync();

        Task<ApiResponse<TypeOfDTO>> GetByID(int id);

        Task<ApiResponse<TypeOfDTO>> AddElement(TypeOfDTO itemDto);

        Task<ApiResponse<TypeOfDTO>> UpdateElement(TypeOfDTO itemDto);

        Task<ApiResponse<TypeOfDTO>> Delete(TypeOfDTO itemDto);

        Task<ApiResponse<TypeOfDTO>> DeleteById(int id);
    }
}
