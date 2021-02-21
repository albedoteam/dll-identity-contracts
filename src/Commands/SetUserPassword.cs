namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface SetUserPassword
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Password { get; set; }
    }
}