using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface PasswordRecoveryCreated
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string ValidationToken { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime ExpiredAt { get; set; }
    }
}