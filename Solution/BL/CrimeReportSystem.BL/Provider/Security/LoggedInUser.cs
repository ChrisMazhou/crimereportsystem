﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCR.Lib.BL;
using CrimeReportSystem.BL.Entities.SecurityData;

namespace CrimeReportSystem.BL.Provider.Security
{
    public class LoggedInUser : ICurrentUser
    {
        public long Id { get; set; }

        public string UserName { get; set; }

        public string DisplayName { get; set; }

        public List<PrivilegeType> AllowedPrivileges { get; set; }

        public bool IsSystemAdmin { get; set; }
    }
}
