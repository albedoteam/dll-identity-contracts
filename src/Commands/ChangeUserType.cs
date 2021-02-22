namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ChangeUserType
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string UserTypeId { get; set; }
    }
}