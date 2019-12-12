﻿using Microsoft.EntityFrameworkCore;
using Peepy.Ims.Domain;
using Peepy.Ims.EFCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Peepy.Ims.Application
{
    public class UserService : IUserService
    {
        public async Task CreateDb()
        {
            using var peppyImsContext = new PeppyImsContext();
            await peppyImsContext.Database.MigrateAsync();
        }
    }
}
