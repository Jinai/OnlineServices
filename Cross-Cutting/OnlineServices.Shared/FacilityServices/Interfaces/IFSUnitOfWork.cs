﻿using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSUnitOfWork : IDisposable
    {
        IComponentRepository ComponentRepository { get; }
        IFloorRepository FloorRepository { get; }
        IIssueRepository IssueRepository { get; }
        IRoomRepository RoomRepository { get; }
        IReportRepository ReportRepository { get; }
        
        void Dispose();
        void Save();
    }
}
