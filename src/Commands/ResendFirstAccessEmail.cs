namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ResendFirstAccessEmail
    {
        string AccountId { get; set; }
        string UserId { get; set; }
    }
}