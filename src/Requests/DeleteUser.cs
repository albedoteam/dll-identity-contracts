namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface DeleteUser
    {
        string AccountId { get; set; }
        string Id { get; set; }
    }
}