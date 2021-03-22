using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserPasswordChangeRequested
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Token { get; set; }
        DateTime RequestedAt { get; set; }
    }
}