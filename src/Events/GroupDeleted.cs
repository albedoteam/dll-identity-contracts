namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface GroupDeleted
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime DeletedAt { get; set; }
    }
}