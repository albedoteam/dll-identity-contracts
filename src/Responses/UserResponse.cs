using System;
using System.Collections.Generic;
using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Responses
{
    public interface UserResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        bool Active { get; set; }
        Dictionary<string, string> CustomProfileFields { get; set; }
        List<string> Groups { get; set; }
        Provider Provider { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}