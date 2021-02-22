using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface GroupAddedToUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string GroupId { get; set; }
        DateTime AddedAt { get; set; }
    }
}