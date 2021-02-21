using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserDeactivated
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime DeactivatedAt { get; set; }
        string Reason { get; set; }
    }
}