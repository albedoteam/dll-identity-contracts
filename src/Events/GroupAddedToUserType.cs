namespace AlbedoTeam.Identity.Contracts.Events
{
    using System;

    public interface GroupAddedToUserType
    {
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string GroupId { get; set; }
        DateTime AddedAt { get; set; }
    }
}