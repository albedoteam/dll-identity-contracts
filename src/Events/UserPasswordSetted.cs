using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserPasswordSetted
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime SettedAt { get; set; }
    }
}