namespace AlbedoTeam.Identity.Contracts.Requests
{
    using System.Collections.Generic;
    using Common;

    public interface CreateUserType
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        List<string> PredefinedGroups { get; set; }
    }
}