using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface GroupDeleted
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime DeletedAt { get; set; }
    }
}