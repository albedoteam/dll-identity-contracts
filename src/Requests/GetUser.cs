namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface GetUser
    {
        string AccountId { get; set; }
        string Id { get; set; }
        bool ShowDeleted { get; set; }
    }
}