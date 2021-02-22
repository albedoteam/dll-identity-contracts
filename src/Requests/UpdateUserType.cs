using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateUserType
    {
        string AccountId { get; set; }
        string Id { get; set; }
        UsernameFormatType UsernameFormatType { get; set; }
        string UsernameFormatExpression { get; set; }
    }
}