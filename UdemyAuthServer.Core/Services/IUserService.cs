﻿using SharedLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.DTOs;

namespace UdemyAuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CtreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}
