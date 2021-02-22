using System;

namespace AlbedoTeam.Identity.Contracts.Events
{
    public interface GroupRemovedFromUserType
    {
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string GroupId { get; set; }
        DateTime RemovedAt { get; set; }
    }
}