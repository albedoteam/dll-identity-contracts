namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateGroup
    {
        string AccountId { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        bool IsDefault { get; set; }
    }
}