using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.ReservationRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.ReservationService
{
    using Type = Reservation;
    using TypeOfDTO = ReservationDTO;
    public class ReservationServ : GenericServ<TypeOfDTO, Type>, IReservationServ
    {
        public readonly IReservationRepo _reservationRepo;
        public readonly IMapper _mapper;
        public ReservationServ(IReservationRepo repo, IMapper mapper) : base(repo, mapper)
        {
            _reservationRepo = repo;
            _mapper = mapper;
        }
    }
}
