﻿namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ClearUserSessions
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Reason { get; set; }
    }
}