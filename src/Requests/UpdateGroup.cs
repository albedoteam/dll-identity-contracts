namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateGroup
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string SuffixName { get; set; }
        string SuffixDescription { get; set; }
        bool IsDefault { get; set; }
    }
}