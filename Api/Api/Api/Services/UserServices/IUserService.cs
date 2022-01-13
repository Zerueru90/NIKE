using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.UserServices
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto user);

    }
}
