namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface RequestPasswordChange
    {
        string AccountId { get; set; }
        string Id { get; set; }
    }
}