using _DAL.Models;
using AutoMapper;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public class MappingProfile :Profile
    {
    public MappingProfile() 
        {
            CreateMap<AirplaneDTO, Airplane>().ReverseMap();
            CreateMap<FlightDTO, Flight>().ReverseMap();
            CreateMap<PassengerDTO, Passenger>().ReverseMap();
            CreateMap<PilotDTO, Pilot>().ReverseMap();  
            CreateMap<ReservationDTO, Reservation>().ReverseMap();  
        }

    }
}
