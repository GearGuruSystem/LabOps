﻿using GG_labOps_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG_LabOps_Services.Interfaces
{
    public interface IUserServices
    {
        Task<User> UpdateUser(int id, User user);
    }
}
