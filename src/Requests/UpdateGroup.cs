namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateGroup
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool IsDefault { get; set; }
    }
}