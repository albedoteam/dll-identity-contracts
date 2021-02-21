namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface ListGroups
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
    }
}