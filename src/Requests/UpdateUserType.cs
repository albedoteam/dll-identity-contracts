namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateUserType
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
    }
}