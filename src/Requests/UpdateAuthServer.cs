namespace AlbedoTeam.Identity.Contracts.Requests
{
    using Common;

    public interface UpdateAuthServer
    {
        string AccountId { get; set; }
        string Id { get; set; }
        ICommunicationRules CommunicationRules { get; set; }
    }
}