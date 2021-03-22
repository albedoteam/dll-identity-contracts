using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateAuthServer
    {
        string AccountId { get; set; }
        string Id { get; set; }
        ICommunicationRules CommunicationRules { get; set; }
    }
}