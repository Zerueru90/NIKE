using Api.Helpers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Model.MappingProfiles
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<UserDto, User>().ForMember(des => des.Password, opt => opt.MapFrom(src => src.Password.GenerateEncryption()));
        }

    }
}
