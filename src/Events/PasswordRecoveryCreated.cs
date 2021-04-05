namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface PasswordRecoveryCreated
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string ValidationToken { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime ExpiredAt { get; set; }
    }
}