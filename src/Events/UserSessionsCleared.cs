namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface UserSessionsCleared
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime ClearedAt { get; set; }
        string Reason { get; set; }
    }
}