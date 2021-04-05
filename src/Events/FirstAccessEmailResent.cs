namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface FirstAccessEmailResent
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        DateTime ResentAt { get; set; }
    }
}