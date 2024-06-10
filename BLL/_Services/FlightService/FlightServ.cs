using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.FlightRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.FlightService
{
    using Type = Flight;
    using TypeOfDTO = FlightDTO;
    public class FlightServ : GenericServ<TypeOfDTO, Type> , IFlightServ
    {
        public readonly IFlightRepo _FlightRepo;
        public readonly IMapper _mapper;

        public FlightServ(IFlightRepo repo, IMapper mapper) : base(repo, mapper)
        {
            _FlightRepo = repo;
            _mapper = mapper;
        }
    }
}
