namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface GetAuthServer
    {
        string AccountId { get; set; }
        string Id { get; set; }
        bool ShowDeleted { get; set; }
    }
}