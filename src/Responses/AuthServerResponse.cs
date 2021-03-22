using System;
using System.Collections.Generic;
using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Responses
{
    public interface AuthServerResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string Name { get; set; }
        string Audience { get; set; }
        string Description { get; set; }
        string Issuer { get; set; }
        string AuthUrl { get; set; }
        string AccessTokenUrl { get; set; }
        string ClientId { get; set; }
        List<string> BasicScopes { get; set; }
        bool Active { get; set; }
        Provider Provider { get; set; }
        string ProviderId { get; set; }
        ICommunicationRules CommunicationRules { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}