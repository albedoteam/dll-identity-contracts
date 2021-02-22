using System.Collections.Generic;
using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateUserType
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
        UsernameFormatType UsernameFormatType { get; set; }
        string UsernameFormatExpression { get; set; }
        List<string> PredefinedGroups { get; set; }
    }
}