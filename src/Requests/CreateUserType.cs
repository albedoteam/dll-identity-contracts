using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateUserType
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
    }
}