namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface DeleteGroup
    {
        string AccountId { get; set; }
        string Id { get; set; }
    }
}