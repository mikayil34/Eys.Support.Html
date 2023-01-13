using Abp.Authorization.Roles;
using Abp.Authorization;
using AutoMapper;
using Eys.Support.Roles.Dto;
using Eys.Support.Authorization.Roles;
using System.Linq;
using Eys.Support.Authorization.Users;
using Eys.Support.Users.Dto;

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
            ConfigureUserMap(config);
            
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

        private static void ConfigureUserMap(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<UserDto, User>();
            configuration.CreateMap<UserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x => x.CreationTime, opt => opt.Ignore());

            configuration.CreateMap<CreateUserDto, User>();
            configuration.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
        }
         
    }
}