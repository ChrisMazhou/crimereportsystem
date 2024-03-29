﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeReportSystem.BL.Provider.Security;
using CrimeReportSystem.BL.Entities.SecurityData;

namespace CrimeReportSystem.Models.Account
{
    [Serializable]
    public class CurrentUserModel:ICurrentUser
    {
        private ICurrentUser _source;

        public CurrentUserModel(ICurrentUser source)
        {
            _source = source;
        }

        public long Id
        {
            get { return _source.Id; }
        }

        public string UserName
        {
            get { return _source.UserName; }
        }

        public string DisplayName
        {
            get { return _source.DisplayName; }
        }

        public List<PrivilegeType> AllowedPrivileges
        {
            get { return _source.AllowedPrivileges; }
        }

        public bool IsSystemAdmin
        {
            get { return _source.IsSystemAdmin; }
        }
    }
}
