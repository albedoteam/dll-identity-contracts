namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface UserPasswordChanged
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime ChangedAt { get; set; }
    }
}