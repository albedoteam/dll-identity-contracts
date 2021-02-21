namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface ListUsers
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
    }
}