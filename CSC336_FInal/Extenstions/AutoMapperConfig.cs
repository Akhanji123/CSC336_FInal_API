using BLL.Mapping;

namespace CSC336_FInal.Extenstions
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection AutoMappingConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;
        }
    }
}
