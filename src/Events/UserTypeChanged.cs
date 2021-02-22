using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserTypeChanged
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string UserTypeId { get; set; }
        DateTime ChangedAt { get; set; }
    }
}