namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface RemoveGroupFromUserType
    {
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string GroupId { get; set; }
    }
}