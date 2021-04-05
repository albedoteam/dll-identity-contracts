namespace AlbedoTeam.Identity.Contracts.Requests
{
    using Common;

    public interface CreateAuthServer
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
    }
}