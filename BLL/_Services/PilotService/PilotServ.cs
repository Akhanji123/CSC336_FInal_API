using _DAL._Repositories._GenericRepository;
using _DAL._Repositories.PilotRepository;
using _DAL.Models;
using AutoMapper;
using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.PilotService
{
    using Type = Pilot;
    using TypeOfDTO = PilotDTO;

    public class PilotServ : GenericServ<TypeOfDTO, Type>, IPilotServ
    {
        public readonly IPilotRep _pilotRep;
        public readonly IMapper _mapper;

        public PilotServ(IPilotRep repo, IMapper mapper) : base(repo, mapper)
        {
            _pilotRep = repo;
            _mapper = mapper;
        }
    }
}
