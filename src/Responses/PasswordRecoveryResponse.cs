using System;

namespace AlbedoTeam.Identity.Contracts.Responses
{
    public interface PasswordRecoveryResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string UserId { get; set; }
        string ValidationToken { get; set; }
        DateTime ExpiresAt { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}