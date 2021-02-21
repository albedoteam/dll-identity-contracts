namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateGroup
    {
        string AccountId { get; set; }
        string SuffixName { get; set; }
        string SuffixDescription { get; set; }
        bool IsDefault { get; set; }
    }
}