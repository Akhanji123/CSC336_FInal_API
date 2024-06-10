using _DAL._Repositories.AirplaneRepository;
using _DAL._Repositories.FlightRepository;
using _DAL._Repositories.PassengerRepository;
using _DAL._Repositories.PilotRepository;
using _DAL._Repositories.ReservationRepository;
using BLL._Services.AirplaneService;
using BLL._Services.FlightService;
using BLL._Services.PassengerService;
using BLL._Services.PilotService;
using BLL._Services.ReservationService;
using BLL.Wrapping.Exceptions;

namespace CSC336_FInal.Extenstions
{
    public static class Dependencies
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAirplaneRepo, AirplaneRepo>();
            services.AddScoped<IFlightRepo, FlightRepo>();
            services.AddScoped<IPassengerRepo, PassengerRepo>();
            services.AddScoped<IPilotRep, PilotRepo>();
            services.AddScoped<IReservationRepo, ReservationRepo>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAirplaneServ, AirplaneServ>();
            services.AddScoped<IFlightServ, FlightServ>();
            services.AddScoped<IPassengerServ, PassengerServ>();
            services.AddScoped<IPilotServ, PilotServ>();
            services.AddScoped<IReservationServ, ReservationServ>();
            return services;
        }

        public static IServiceCollection AddExeptionService(this IServiceCollection services)
        {
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();
            return services;
        }
    }
}
