﻿using CoronaApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public interface IUserRepository
    {
        Task<string> CreateToken(string userName, string password);
        Task PostUser(User user);
        //string getUserName();
    }
}
