using Abp.Authorization.Roles;
using Abp.Authorization;
using AutoMapper;
using Eys.Support.Roles.Dto;
using Eys.Support.Authorization.Roles;
using System.Linq;

namespace Eys.Support.Mapper
{
    public class DtoMapperConfiguration
    {
        public static IMapper Mapper { get; set; }

        static DtoMapperConfiguration()
        {
            var config = new MapperConfiguration(ConfigureMapper);

            Mapper = config.CreateMapper();
        }

        public static void ConfigureMapper(IMapperConfigurationExpression config)
        {
            ConfigureRolMap(config);
            ConfigureModuleMap(config);
            
        }

        private static void ConfigureRolMap(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            configuration.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            configuration.CreateMap<CreateRoleDto, Role>();

            configuration.CreateMap<RoleDto, Role>();

            configuration.CreateMap<Role, RoleDto>().ForMember(x => x.GrantedPermissions,
                opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

            configuration.CreateMap<Role, RoleListDto>();
            configuration.CreateMap<Role, RoleEditDto>();
            configuration.CreateMap<Permission, FlatPermissionDto>();
        }

        private static void ConfigureModuleMap(IMapperConfigurationExpression configuration)
        {
            //configuration.CreateMap<ModuleDTO, Module>();
            //configuration.CreateMap<Module, ModuleDTO>();
        }
         
    }
}