using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserPasswordChanged
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime ChangedAt { get; set; }
    }
}