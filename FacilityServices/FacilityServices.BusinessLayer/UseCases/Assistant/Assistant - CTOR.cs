﻿using OnlineServices.Common.FacilityServices;
using OnlineServices.Common.FacilityServices.Enumerations;
using OnlineServices.Common.FacilityServices.Interfaces;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AssistantRole : AttendeeRole, IFSAssistantRole
    {
        private readonly IFSUnitOfWork iFSUnitOfWork;

        public AssistantRole(IFSUnitOfWork iFSUnitOfWork) : base(iFSUnitOfWork)
        {
            this.iFSUnitOfWork = iFSUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFSUnitOfWork));
        }

    }
}