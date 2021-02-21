namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface ListAuthServers
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
    }
}