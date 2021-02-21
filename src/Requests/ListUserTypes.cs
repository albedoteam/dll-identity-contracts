namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface ListUserTypes
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
    }
}