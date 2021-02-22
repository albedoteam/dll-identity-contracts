namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ChangeUserTypeOnUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string UserTypeId { get; set; }
    }
}