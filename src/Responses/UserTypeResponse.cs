using System;
using System.Collections.Generic;
using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Responses
{
    public interface UserTypeResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string DisplayName { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<string> PredefinedGroups { get; set; }
        Provider Provider { get; set; }
        string ProviderId { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}