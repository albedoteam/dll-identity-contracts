namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface GroupRemovedFromUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string GroupId { get; set; }
        DateTime RemovedAt { get; set; }
    }
}