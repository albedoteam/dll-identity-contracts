using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface PasswordRecoveryCreated
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string ValidationToken { get; set; }
        DateTime CreatedAt { get; set; }
    }
}