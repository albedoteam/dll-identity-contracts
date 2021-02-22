using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface GroupRemovedFromUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string GroupId { get; set; }
        DateTime RemovedAt { get; set; }
    }
}