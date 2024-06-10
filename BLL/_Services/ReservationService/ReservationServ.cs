using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.FlightRepository;
using _DAL._Repositories.PassengerRepository;
using _DAL._Repositories.ReservationRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL._Services.ReservationService
{
    using Type = Reservation;
    using TypeOfDTO = ReservationDTO;
    public class ReservationServ : GenericServ<TypeOfDTO, Type>, IReservationServ
    {
        public readonly IReservationRepo _reservationRepo;
        public readonly IMapper _mapper;
        public readonly IPassengerRepo _passengerRepo;
        public readonly IFlightRepo _flightRepo;
        public ReservationServ(IReservationRepo repo, IPassengerRepo passengerrepo, IFlightRepo flightrepo, IMapper mapper) : base(repo, mapper)
        {
            _reservationRepo = repo;
            _passengerRepo = passengerrepo;
            _flightRepo = flightrepo;
            _mapper = mapper;
        }


        public async Task<ApiResponse<AddResWithPassAndFlight>> AddingResWithPassAndFlight(AddResWithPassAndFlight ResWithPassAndFlightDTO)
        {
            ApiResponse<AddResWithPassAndFlight> response = new ApiResponse<AddResWithPassAndFlight>();
            using (var transaction = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }, TransactionScopeAsyncFlowOption.Enabled))
                try
                {
                    var passengerResult =await  _passengerRepo.AddElement(_mapper.Map<Passenger>(ResWithPassAndFlightDTO.passengerDTO));
                    var FlightResult = await _flightRepo.AddElement(_mapper.Map<Flight>(ResWithPassAndFlightDTO.flightDTO));

                    ResWithPassAndFlightDTO.PassengerId = passengerResult.PassengerId;
                    ResWithPassAndFlightDTO.FlightId = FlightResult.FlightId;
               
                   var reservationResult = await _reservationRepo.AddElement(_mapper.Map<Type>(ResWithPassAndFlightDTO));
                    transaction.Complete();
                    response.Data = ResWithPassAndFlightDTO;
                    return response;
            }
                catch (Exception ex) 
                {
                    transaction.Dispose();
                    throw;
                }


        }
    }
}
