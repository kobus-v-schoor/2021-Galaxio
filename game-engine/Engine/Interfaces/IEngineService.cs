﻿using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace Engine.Interfaces
{
    public interface IEngineService
    {
        Task GameRunLoop();
        bool GameStarted { get; set; }
        bool HasWinner { get; set; }
        bool PendingStart { get; set; }
        int TickAcked { get; set; }
        HubConnection SetHubConnection(ref HubConnection connection);
    }
}