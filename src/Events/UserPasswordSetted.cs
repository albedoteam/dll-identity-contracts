namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface UserPasswordSetted
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime SettedAt { get; set; }
    }
}