namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface CreatePasswordRecovery
    {
        string AccountId { get; set; }
        string UserEmail { get; set; }
    }
}