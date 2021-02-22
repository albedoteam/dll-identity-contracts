namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface AddGroupToUser
    {
        string AccountId { get; set; }
        string UserId { get; set; }
        string GroupId { get; set; }
    }
}