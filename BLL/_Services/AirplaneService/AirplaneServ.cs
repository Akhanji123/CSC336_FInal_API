using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.AirplaneRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.AirplaneService
{
    using Type = Airplane;
    using TypeOfDTO = AirplaneDTO;
    public class AirplaneServ : GenericServ<AirplaneDTO, Airplane>, IAirplaneServ
    {
        public readonly IAirplaneRepo _airplaneRepo;
        public readonly IMapper _mapper;

        public AirplaneServ(IAirplaneRepo repo, IMapper mapper) : base(repo, mapper)
        {
            _airplaneRepo = repo;
            _mapper = mapper;
        }
    }
}
