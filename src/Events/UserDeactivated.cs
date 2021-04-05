namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface UserDeactivated
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime DeactivatedAt { get; set; }
        string Reason { get; set; }
    }
}