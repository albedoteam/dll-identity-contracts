using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateAuthServer
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
    }
}