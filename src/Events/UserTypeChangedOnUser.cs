namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface UserTypeChangedOnUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string UserTypeId { get; set; }
        DateTime ChangedAt { get; set; }
    }
}