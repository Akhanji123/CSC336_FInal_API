using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.PassengerRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.PassengerService
{
    using Type = Passenger;
    using TypeOfDTO = PassengerDTO;
    public class PassengerServ : GenericServ<TypeOfDTO, Type>, IPassengerServ
    {
        public readonly IMapper _mapper;
        public readonly IPassengerRepo _passengerRepo;
        public PassengerServ(IPassengerRepo repo, IMapper mapper) : base(repo, mapper)
        {
            _passengerRepo = repo;
            _mapper = mapper;
        }
    }
}
