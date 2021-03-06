namespace AlbedoTeam.Identity.Contracts.Requests
{
    using Common;

    public interface CreateGroup
    {
        string AccountId { get; set; }
        Provider Provider { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        bool IsDefault { get; set; }
    }
}