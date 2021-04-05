namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface AuthServerActivated
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime ActivatedAt { get; set; }
        string Reason { get; set; }
    }
}