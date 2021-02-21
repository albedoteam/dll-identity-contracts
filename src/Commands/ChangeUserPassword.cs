namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ChangeUserPassword
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string OldPassword { get; set; }
        string NewPassword { get; set; }
    }
}