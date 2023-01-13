using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eys.Support.Authorization;
using Eys.Support.Mapper;

namespace Eys.Support
{
    [DependsOn(
        typeof(SupportCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SupportApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SupportAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(DtoMapperConfiguration.ConfigureMapper);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SupportApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
