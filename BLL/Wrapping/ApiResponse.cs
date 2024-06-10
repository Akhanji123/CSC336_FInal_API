using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Wrapping
{
    public class ApiResponse<Type>
    {
        public bool Success { get; set; }
        public Type Data { get; set; }
        public string Meesage { get; set; }
        public string ErrorMessage { get; set; }

        public ApiResponse()
        {
            Success = true;
        }
    }
}
