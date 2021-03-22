using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface UserPasswordExpired
    {
        string AccountId { get; set; }
        string Id { get; set; }
        DateTime ExpiredAt { get; set; }
        string Reason { get; set; }
        string TemporaryPassword { get; set; }
    }
}